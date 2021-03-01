using Cerner.PFTFramework;
using System;
using System.Windows.Forms;

namespace Cerner.PFT_COLLECTION_TOOL
{
    internal partial class frmCollectionLetter
         : Cerner.ApplicationFramework.GUI.CernerStyledControls.CernerStyledForm
    {
        private CCollectionView mParent = null;
        private bool mbShutDownFromView = false;
        private const string DunningLevel_CD = "25095";

        private double[] mad25095 = null;
        private string[] mas25095 = null;

        private PatientAccountingSearch.CBESearch oBESearch = null; //TL4790 08/11/00  used to call BESearch
        private double[] aBE_id = null; //get information from BESearch
        private string[] aBE_display = null;
        private int lCount = 0;

        //Called by the View, letting us know that the
        //View will be taking responsibility for
        //unloading this form.
        public int ShutDownFromView()
        {
            mbShutDownFromView = true;
            return 0;
        }

        //Reference to the View class.

        //Reference to the View class.
        public CCollectionView Parent_Renamed
        {
            get
            {
                return mParent;
            }
            set
            {
                mParent = value;
            }
        }

        private void chkDisable_CheckStateChanged(Object eventSender, EventArgs eventArgs)
        {
            Picture2.Enabled = true;

            //checks to see if the disable check box was checked, and update the disable flag.
            if (chkDisable.CheckState == CheckState.Checked)
            {
                mParent.disable_flg = 1;
            }
            else
            {
                mParent.disable_flg = 0;
            }

            ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::chkDisable_click:Exit", LogLevel.logDebug3);
            return;
        }

        //001    TL4790  07/14/00    Modify MsgBox to include titles
        //002    TL4790  08/11/00    Added Billing Entity
        private void cmbDunningCd_SelectionChangeCommitted(Object eventSender, EventArgs eventArgs)
        {
            ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::cmbDunningCd", LogLevel.logAudit2);
            int lStatus = 0;
            try
            {
                DialogResult nRet = DialogResult.None;

                mParent.dunning_level_cd = mad25095[this.cmbDunningCd.SelectedIndex]; // 0 or 1 based??

                lStatus = mParent.lGetCollectionInfo();
                if (lStatus != ProFitData.PFT_SUCCESS)
                {
                    ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::cmbDunningCd_Click - failed to call the lGetCollectionInfo", (LogLevel.logError0) - 1);
                    //Mod 001
                    //MsgBox i18nGetMessage(msMODULE_NAME, "1474", glNO_INDEX, "There is no message for this dunning level. Do you want to add a message?"), , i18nGetMessage(msMODULE_NAME, "1481", glNO_INDEX, "Error") 'i18n
                    //MOD 002
                    nRet = Cerner.Foundations.Measurement.TimedMessageBox.Show(ResourceHandler.Resources.GetString("1474"), ResourceHandler.Resources.GetString("1481"), MessageBoxButtons.YesNo); //i18n
                    for (int x = 1; x <= txtLetter.Length - 1; x++)
                    {
                        //        txtLetter(x).Enabled = True
                        txtLetter[x].Text = System.String.Empty;
                    }

                    //MOD 002
                    if (nRet == System.Windows.Forms.DialogResult.Yes)
                    {
                        for (int x = 1; x <= txtLetter.Length - 1; x++)
                        {
                            txtLetter[x].Enabled = true;
                            cmdSave.Enabled = true;
                            Toolbar1.Items[0].Enabled = true;
                        }
                    }
                    else
                    {
                        for (int x = 1; x <= txtLetter.Length - 1; x++)
                        {
                            txtLetter[x].Enabled = false;
                            cmdSave.Enabled = false;
                            Toolbar1.Items[0].Enabled = false;
                        }
                    }
                    //End MOD 002

                    return;
                }

                this.Cursor = Cursors.WaitCursor;

                for (int x = 1; x <= txtLetter.Length - 1; x++)
                {
                    txtLetter[x].Enabled = true;
                    txtLetter[x].Text = System.String.Empty;
                }

                txtLetter[1].Text = mParent.letter_line1;
                txtLetter[2].Text = mParent.letter_line2;
                txtLetter[3].Text = mParent.letter_line3;
                txtLetter[4].Text = mParent.letter_line4;
                txtLetter[5].Text = mParent.letter_line5;
                txtLetter[6].Text = mParent.letter_line6;
                txtLetter[7].Text = mParent.letter_line7;
                txtLetter[8].Text = mParent.letter_line8;
                txtLetter[9].Text = mParent.letter_line9;
                txtLetter[10].Text = mParent.letter_line10;
                txtLetter[11].Text = mParent.letter_line11;
                txtLetter[12].Text = mParent.letter_line12;
                txtLetter[13].Text = mParent.letter_line13;
                txtLetter[14].Text = mParent.letter_line14;
                txtLetter[15].Text = mParent.letter_line15;

                if (Enum.IsDefined(typeof(CheckState), mParent.disable_flg))
                {
                    chkDisable.CheckState = (CheckState)mParent.disable_flg;
                }
                cmdSave.Enabled = true;
                chkDisable.Enabled = true;
                Toolbar1.Items[0].Enabled = true;

                if (chkDisable.CheckState == CheckState.Checked)
                {
                    for (int Y = 1; Y <= txtLetter.Length - 1; Y++)
                    {
                        txtLetter[Y].Enabled = false;
                    }
                }

                ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::cmbDunningDd_Click - Exit", LogLevel.logAudit2);
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);
                ProFitData.gFRWKSVC.SysLog("frmCollectionLetter:cmbDunningCd_click - Error", LogLevel.logDebug3);
                ProFitData.gFRWKSVC.SysLog("lstatus " + lStatus.ToString(), LogLevel.logTrace4);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        //Purpose:   Calls the Billing Entity Search in order to retrieve the billing entity id
        //            and billing entity display value
        //Author:    Tonya Luff  TL4790
        //           08/11/00
        //
        private void cmdBESearch_Click(Object eventSender, EventArgs eventArgs)
        {
            int nSelection_type = 0;
            int lStatus = 0;

            ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::cmdBESearch_Click:Enter", LogLevel.logDebug3);

            try
            {
                cmdBESearch.Enabled = false;
                nSelection_type = 1;

                //create the BESearch object
                oBESearch = new PatientAccountingSearch.CBESearch();
                if (oBESearch == null)
                {
                    ProFitData.gFRWKSVC.SysLog("Error creating billing entity search", LogLevel.logDebug3);
                    return;
                }

                oBESearch.Parent = mParent.Parent;

                //?? optional parameter of active selection??
                lStatus = oBESearch.lFindBEFG(nSelection_type, ProFitData.gFRWKSVC.domain, ProFitData.gFRWKSVC.User, PatientAccountingSearch.CBESearch.besearch_active_enum.pftBE_Active_Only);
                if (lStatus != ProFitData.PFT_SUCCESS)
                {
                    ProFitData.gFRWKSVC.SysLog("Error in billing entity search", LogLevel.logDebug3);
                    return;
                }
                else
                {
                    //normal termination
                    ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::cmdBESearch_Click - Exit", LogLevel.logAudit2);
                    return;
                }
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);
                ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::cmdBESearchClick:Error", LogLevel.logAudit2);
                cmdBESearch.Enabled = true;
                Cerner.Foundations.Measurement.TimedMessageBox.Show(ResourceHandler.Resources.GetString("1482"), ResourceHandler.Resources.GetString("1475"), MessageBoxButtons.OK); //i18n
            }
        }

        private void cmdExit_Click(Object eventSender, EventArgs eventArgs)
        {
            //initialize the error handler routine
            try
            {
                //unload the form
                this.Close();
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);

                //log an abnormal termination
                ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::cmdUpdate_Click - Abnormal Termination", LogLevel.logDebug3);
            }
        }

        //001    TL4790  07/14/00    Modify MsgBox to include titles
        //002    TL4790  08/11/00    Added Billing entity
        private void cmdSave_Click(Object eventSender, EventArgs eventArgs)
        {
            ProFitData.gFRWKSVC.SysLog("frmCollectionLette::cmdSave_Click:Enter", LogLevel.logDebug3);
            int lStatus = 0;
            try
            {
                //TL4790     08/11/00
                //make sure billing entity is not "Null"
                if (string.IsNullOrEmpty(txtBillingEntity.Text))
                {
                    Cerner.Foundations.Measurement.TimedMessageBox.Show(ResourceHandler.Resources.GetString("1483"), ResourceHandler.Resources.GetString("1479"), MessageBoxButtons.OK); //i18n
                    ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::cmdSaveClick - No Billing Entity selected", LogLevel.logAudit2);
                    return;
                }
                //End TL4790 08/11/00
                mParent.letter_line1 = txtLetter[1].Text;
                mParent.letter_line2 = txtLetter[2].Text;
                mParent.letter_line3 = txtLetter[3].Text;
                mParent.letter_line4 = txtLetter[4].Text;
                mParent.letter_line5 = txtLetter[5].Text;
                mParent.letter_line6 = txtLetter[6].Text;
                mParent.letter_line7 = txtLetter[7].Text;
                mParent.letter_line8 = txtLetter[8].Text;
                mParent.letter_line9 = txtLetter[9].Text;
                mParent.letter_line10 = txtLetter[10].Text;
                mParent.letter_line11 = txtLetter[11].Text;
                mParent.letter_line12 = txtLetter[12].Text;
                mParent.letter_line13 = txtLetter[13].Text;
                mParent.letter_line14 = txtLetter[14].Text;
                mParent.letter_line15 = txtLetter[15].Text;
                mParent.dunning_level_cd = mad25095[this.cmbDunningCd.SelectedIndex]; // 0 or 1 based??
                mParent.disable_flg = (int)chkDisable.CheckState;
                lStatus = mParent.lAddCollection();

                if (lStatus != ProFitData.PFT_SUCCESS)
                {
                    ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::cmdSave_click - failed the call to the lsave", LogLevel.logDebug3);
                }
                //Mod 001
                Cerner.Foundations.Measurement.TimedMessageBox.Show(ResourceHandler.Resources.GetString("1473"), ResourceHandler.Resources.GetString("1478")); //i18n

                ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::cmdSaveClick - exit", LogLevel.logDebug3);
                return;
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);
                //log abnormal termination
                ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::cmdSaveClick - Error", LogLevel.logAudit2);
                ProFitData.gFRWKSVC.SysLog("lstatus " + lStatus.ToString(), LogLevel.logTrace4);
            }
            finally
            {
                this.Cursor = Cursors.Default;                
            }
        }        

        private void frmCollectionLetter_Activated(Object eventSender, EventArgs eventArgs)
        {
            if (Cerner.ApplicationFramework.ConversionSupport.Gui.ActivateHelper.myActiveForm != eventSender)
            {
                Cerner.ApplicationFramework.ConversionSupport.Gui.ActivateHelper.myActiveForm = (Form)eventSender;

                //Log Activation of Form
                ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::Activation", LogLevel.logAudit2);

                //The form just became active, so lets tell
                //the View class about it.
                Parent_Renamed.lActivateView();
            }
        }

        private void Form_Initialize_Renamed()
        {
            ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::Initialize", LogLevel.logAudit2);

            mbShutDownFromView = false;
        }

        //MOD 001    Tonya Luff TL4790   08/14/00    Added functionality for billing entity
        private void frmCollectionLetter_Load(Object eventSender, EventArgs eventArgs)
        {
            ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::Load:Enter", LogLevel.logDebug3);
            int lStatus = 0;
            try
            {
                int Y = 0;

                cmdSave.Enabled = false;
                chkDisable.Enabled = false;

                //gets the appropriate codesets and puts them in the correct combo box
                csthidden.GetCodeSet(Convert.ToInt32(Convert.ToDouble(DunningLevel_CD)));
                mad25095 = new double[1];
                mas25095 = new string[] { String.Empty };

                Y = 0;

                cmbDunningCd.BeginUpdate();
                for (int x = 0; x <= (int)(csthidden.ListCount() - 1); x++)
                {
                    csthidden.ListIndex = x;

                    if (!((string.Compare(csthidden.CodeMeaning(), "NORMAL1", true) == 0) || (string.Compare(csthidden.CodeMeaning(), "NORMAL2", true) == 0) || (string.Compare(csthidden.CodeMeaning(), "NORMAL3", true) == 0)))
                    {
                        Array.Resize<string>(ref mas25095, Y + 1);
                        Array.Resize<double>(ref mad25095, Y + 1);
                        mas25095[Y] = csthidden.CodeDisplay();
                        mad25095[Y] = csthidden.CodeValue();
                        cmbDunningCd.Items.Add(csthidden.CodeDisplay());
                        Y++;
                    }
                }
                cmbDunningCd.EndUpdate();
                for (int x = 1; x <= txtLetter.Length - 1; x++)
                {
                    txtLetter[x].Enabled = false;
                }
                Toolbar1.Items[0].ImageKey = "save";
                Toolbar1.Items[1].ImageKey = "Exit";

                Toolbar1.Items[0].Enabled = false;

                Toolbar1.Items[0].ToolTipText = ResourceHandler.Resources.GetString("1478"); //"Save" 'i18n
                Toolbar1.Items[1].ToolTipText = ResourceHandler.Resources.GetString("1479"); //"Exit" 'i18n
                ToolTip1.SetToolTip(cmbDunningCd, ResourceHandler.Resources.GetString("1480")); //"Dunning Code" 'i18n

                //MOD 001
                cmbDunningCd.Enabled = false;
                //End MOD 001

                ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::FormLoad: Exit", LogLevel.logDebug3);
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);
                ProFitData.gFRWKSVC.SysLog("frmCollectionLeter::FormLoad: Error", LogLevel.logAudit2);
                ProFitData.gFRWKSVC.SysLog("lstatus " + lStatus.ToString(), LogLevel.logTrace4);
            }
        }

        //Before a form disappears, it needs to know who's making it
        //disappear. If the form is closing on its own, it needs to
        //notify its Parent View class, so the View can release its
        //reference. Otherwise, the View already knows and all we
        //need to do is release our reference to the View.
        private void frmCollectionLetter_FormClosing(Object eventSender, FormClosingEventArgs eventArgs)
        {
            int Cancel = (eventArgs.Cancel) ? 1 : 0;
            //int UnloadMode = (int) eventArgs.CloseReason;

            //If the View is shutting us down.
            if (mbShutDownFromView)
            {
                //Release our reference to the View.
                mParent = null;
            }
            else
            {
                //Otherwise,
                //we're shutting ourself down, so we need to let
                //the View know, so it can release its reference.
                Parent_Renamed.lReleaseForm();

                //Release our reference to the View.
                mParent = null;
            }

            eventArgs.Cancel = Cancel != 0;
        }

        private void Form_Terminate_Renamed()
        {
            //Log destruction of Form.
            ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::Terminate", LogLevel.logAudit2);

            mParent = null;
        }

        private void Toolbar1_ButtonClick(Object eventSender, EventArgs eventArgs)
        {
            ToolStripItem Button = (ToolStripItem)eventSender;

            try
            {
                switch (Button.Name)
                {
                    case "Save":
                        cmdSave_Click(cmdSave, new EventArgs());
                        break;

                    case "Exit":
                        cmdExit_Click(cmdExit, new EventArgs());
                        break;
                }
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);
                ProFitData.gFRWKSVC.SysLog("frmToolBar1_buttonClick:Error", LogLevel.logAudit2);
            }
        }

        private void txtLetter_TextChanged(Object eventSender, EventArgs eventArgs)
        {
            int Index = Array.IndexOf(txtLetter, eventSender);
            if ((txtLetter[Index].Text.Length) > 70 && txtLetter[Index].Text.EndsWith(" "))
            {
                if (Index < 15)
                {
                    txtLetter[Index + 1].Focus();
                    return;
                }
            }
            if ((txtLetter[Index].Text.Length) == 80)
            {
                if (Index < 15)
                {
                    txtLetter[Index + 1].Focus();
                    return;
                }
            }
            if ((txtLetter[Index].Text.Length) > 80)
            {
                if (Index < 15)
                {
                    txtLetter[Index + 1].Focus();

                    int substringLength = 80;

                    while (char.IsLetterOrDigit(txtLetter[Index].Text[substringLength]))
                    {
                        substringLength--;
                    };
                    string temp = txtLetter[Index].Text.Substring(0, substringLength);
                    txtLetter[Index + 1].Text = (txtLetter[Index].Text.Remove(0, substringLength) + txtLetter[Index + 1].Text.Trim()).Trim();
                    txtLetter[Index].Text = string.Empty;
                    txtLetter[Index].Text = temp;

                    return;
                }
            }
        }

        private void txtLetter_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
        {
            int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
            int Index = Array.IndexOf(txtLetter, eventSender);
            if (KeyAscii == ((int)Keys.Return))
            {
                if (Index < 15)
                {
                    txtLetter[Index + 1].Focus();
                    if (KeyAscii == 0)
                    {
                        eventArgs.Handled = true;
                    }
                    return;
                }
            }

            if (KeyAscii == 0)
            {
                eventArgs.Handled = true;
            }
            eventArgs.KeyChar = Convert.ToChar(KeyAscii);
        }

        //get the data from the referenced searches
        internal int lGetSearchData(string rsFrom)
        {
            int result = 0;
            ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::lGetSearchData", LogLevel.logAudit2);

            try
            {
                int lSeaStatus = 0; //status result from search
                PFTFramework.CMessage oMsg = null; //Message object

                if (string.Compare(rsFrom, "BESEARCH", true) == 0)
                {
                    aBE_id = new double[3];
                    aBE_display = new string[] { String.Empty, String.Empty, String.Empty };
                    //Get the search data from account search
                    lSeaStatus = oBESearch.lGetBEData(ref aBE_id, ref aBE_display, ref lCount);

                    this.Cursor = Cursors.WaitCursor;

                    if (lSeaStatus == ProFitData.PFT_SUCCESS)
                    {
                        if (lCount > 0)
                        {
                            mParent.Data.BillingEntityID = aBE_id[0];
                            txtBillingEntity.Text = aBE_display[0];
                        }
                    }
                    else
                    {
                        ProFitData.gFRWKSVC.SysLog("We got back a failure from lGetBEData", LogLevel.logDebug3);
                        result = lSeaStatus;
                        return result;
                    }

                    //send a message to the AcctSearch to destroy itself
                    oMsg = new PFTFramework.CMessage();
                    oMsg.MessageType = eMessageType.MSG_DESTROY;
                    oBESearch.Message(ref oMsg);
                    oBESearch = null;
                    oMsg = null;

                    cmdBESearch.Enabled = true;
                    cmbDunningCd.Text = System.String.Empty;
                    cmbDunningCd.Enabled = true;
                    for (int n = 1; n <= 15; n++)
                    {
                        txtLetter[n].Text = System.String.Empty;
                    }

                    result = ProFitData.PFT_SUCCESS;
                    ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::lGetSearchData:Normal termination", LogLevel.logAudit2);
                    return result;
                }
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);
                ProFitData.gFRWKSVC.SysLog("frmCollectionLetter::lGetSearchData:Error", LogLevel.logAudit2);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            return result;
        }
    }
}