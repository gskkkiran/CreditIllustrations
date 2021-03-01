using Cerner.PFTFramework;
using System;
using System.Windows.Forms;

namespace Cerner.PFT_COLLECTION_TOOL
{
    internal class CCollectionView : IDisposable
    {
        private CCollection mParent = null;
        private frmCollectionLetter mCurForm = null;
        private CCollectionData mData = new CCollectionData();
        private int lStatus = 0;

        internal int lAddCollection()
        {
            lStatus = mData.lAddCollection();
            if (lStatus != ProFitData.PFT_SUCCESS)
            {
                ProFitData.gFRWKSVC.SysLog("CCollectionView::lAddCollection - failed to call the data class", LogLevel.logDebug3);
            }
            return lStatus;
        }

        internal int lGetCollectionInfo()
        {
            int result = 0;
            result = mData.lGetCollectionInfo();
            if (lStatus != ProFitData.PFT_SUCCESS)
            {
                ProFitData.gFRWKSVC.SysLog("CCollectionView::lGetCollectionInfo - failed to call the data class", LogLevel.logDebug3);
                return result;
            }

            return result;
        }

        //Author:    Mandy Ossana
        //Purpose:   Controlling method for loading frmApplication
        //Written:   3-22-2000
        //Modifications:
        //000    MV4772          Initial release
        internal int lShowForm()
        {
            //initialize error handler
            int result = ProFitData.PFT_FAILURE;
            try
            {
                //logs the entrance into this method
                ProFitData.gFRWKSVC.SysLog("CCollectionView::lShowForm - Entrnace", LogLevel.logAudit2);

                //local variables
                int lStatus = 0;

                //determines if the form already exists
                if (mCurForm == null)
                {
                    //instantiate the form
                    mCurForm = new frmCollectionLetter();

                    //set the form's parent reference to this class
                    mCurForm.Parent_Renamed = this;

                    //validate the call
                    if (lStatus != ProFitData.PFT_SUCCESS)
                    {
                        //log the failure of the lGetConds call
                        ProFitData.gFRWKSVC.SysLog("CCollectionView::lShowForm - lGetConds failed", LogLevel.logDebug3);
                        ProFitData.gFRWKSVC.SysLog("CCollectionView::lShowForm - lStatus:  " + lStatus.ToString(), LogLevel.logDebug3);

                        //send control to error handler
                        return ProFitData.PFT_FAILURE;
                    }

                    //Show it
                    mCurForm.Show();
                }
                else
                {
                    //One's already been created, so just Activate it (see below).
                    lStatus = lActivateForm();

                    if (lStatus != ProFitData.PFT_SUCCESS)
                    {
                        //log the failure of the ActivateForm call
                        ProFitData.gFRWKSVC.SysLog("CCollectionView::lShowForm - ActivateForm failed", LogLevel.logDebug3);
                        ProFitData.gFRWKSVC.SysLog("CCollection::lShowForm - lStatus:  " + lStatus.ToString(), LogLevel.logDebug3);

                        //set return value to failure
                        result = ProFitData.PFT_FAILURE;

                        //send control to error handler
                        return result;
                    }
                    else
                    {
                        //log the success of the ActivateForm call
                        ProFitData.gFRWKSVC.SysLog("CCollectionView::lShowForm - ActivateForm succeeded", LogLevel.logDebug3);
                    }
                }

                //change pointer back to normal
                Cursor.Current = Cursors.Default;

                //log a normal termination
                ProFitData.gFRWKSVC.SysLog("CCollectionView::lShowForm - Normal Termination", LogLevel.logAudit2);

                //return a normal termination state

                return ProFitData.PFT_SUCCESS;
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);

                //change pointer back to normal
                Cursor.Current = Cursors.Default;

                //ensure the function returns error status
                if (result == ProFitData.PFT_SUCCESS)
                {
                    result = ProFitData.PFT_FAILURE;
                }

                //log abnormal termination
                ProFitData.gFRWKSVC.SysLog("CCollectionView::lShowForm - Abnormal Termination", LogLevel.logAudit2);

                return result;
            }
        }

        //Author:    Mandy Ossana
        //Purpose:   Handles the notification that the form wants to terminate
        //Written:   3-22-2000
        //Modifications:
        //000        Mandy Ossana        Initial Release

        internal int lReleaseForm()
        {
            //initializes the error handler
            int result = ProFitData.PFT_FAILURE;
            try
            {
                ProFitData.gFRWKSVC.SysLog("CCollectionView::lReleaseForm - Entrance", LogLevel.logAudit2);

                //local variables
                int lStatus = 0;

                //determine if parent reference is good
                if (mParent != null)
                {
                    //request that the view be release
                    lStatus = mParent.ReleaseView();
                    //check the status
                    if (lStatus != ProFitData.PFT_SUCCESS)
                    {
                        //log the shut down problem
                        ProFitData.gFRWKSVC.SysLog("CCollectionView::lReleaseForm - Parent.lReleaseView failed", LogLevel.logDebug3);
                        ProFitData.gFRWKSVC.SysLog("CCollectionView::lReleaseForm - lStatus:  " + lStatus.ToString(), LogLevel.logDebug3);
                    }
                }

                //log a success
                ProFitData.gFRWKSVC.SysLog("CCollectionView::lReleaseForm - Normal Termination", LogLevel.logAudit2);
                //return success
                //normal termination
                return ProFitData.PFT_SUCCESS;
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);

                //abnormal termination
                if (result == ProFitData.PFT_SUCCESS)
                {
                    result = ProFitData.PFT_FAILURE;
                }
                ProFitData.gFRWKSVC.SysLog("CCollectionView::lReleaseForm - Abnormal Termination", LogLevel.logAudit2);

                return result;
            }
            finally
            {
                //cleanup code
                if (mParent != null)
                {
                    mParent.Dispose();
                    mParent = null;
                }
                if (mData != null)
                {
                    mData.Dispose();
                    mData = null;
                }
                if (mCurForm != null)
                {
                    mCurForm.Dispose();
                    mCurForm = null;
                }
            }
        }

        //Author:    Mandy Ossana
        //Purpose:   Handles the notification that the implementation class wants to teminate
        //Written:   3-22-2000
        //Modifications:
        //000        MV4772              Initial release
        internal int lShutDownFromParent()
        {
            //init error handler
            int result = ProFitData.PFT_FAILURE;
            try
            {
                //log entrance
                ProFitData.gFRWKSVC.SysLog("CCollectionView::lShutDownFromParent - Entrance", LogLevel.logAudit2);

                //local variables
                int lStatus = 0;

                //determine if mcurForm's reference is good
                if (mCurForm != null)
                {
                    //request that the view be release
                    lStatus = mCurForm.ShutDownFromView();
                    //check the status
                    if (lStatus != ProFitData.PFT_SUCCESS)
                    {
                        //log the shut down problem
                        ProFitData.gFRWKSVC.SysLog("CCollectionView::lShutDownFromParent - mcurForm.ShutDownFromView failed", LogLevel.logDebug3);
                        ProFitData.gFRWKSVC.SysLog("CCollectionView::lShutDownFromParent - lStatus:  " + lStatus.ToString(), LogLevel.logDebug3);
                    }
                }

                //log a success
                ProFitData.gFRWKSVC.SysLog("CCollectionView::lShutDownFromParent - Normal Termination", LogLevel.logAudit2);
                //return success
                //normal termination
                return ProFitData.PFT_SUCCESS;
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);

                //abnormal termination
                if (result == ProFitData.PFT_SUCCESS)
                {
                    result = ProFitData.PFT_FAILURE;
                }
                ProFitData.gFRWKSVC.SysLog("cCollectionView::lShutDownFromParent - abnormal termination", LogLevel.logAudit2);

                return result;
            }
            finally
            {
                //cleanup code
                if (mParent != null)
                {
                    mParent.Dispose();
                    mParent = null;
                }
                if (mData != null)
                {
                    mData.Dispose();
                    mData = null;
                }
                if (mCurForm != null)
                {
                    mCurForm.Dispose();
                    mCurForm = null;
                }
            }
        }

        public void lActivateView()
        {
            //We use the Windows API SetFocus to properly execute
            //the SetFocus method
            //get the handle for the calling form
            mCurForm.Focus();  
        }

        internal int lMessageReply(PFTFramework.CMessage roMsg)
        {
            int result = 0;
            int lStatus = 0;

            ProFitData.gFRWKSVC.SysLog("CCollectionViewEnter", LogLevel.logAudit2);

            result = ProFitData.PFT_FAILURE;

            try
            {
                if (mCurForm != null)
                {
                    switch (Convert.ToString(roMsg.Variable2))
                    {
                        case "GETFOCUS":
                            if (mCurForm != null)
                            {
                                lStatus = lActivateForm();
                                if (lStatus != ProFitData.PFT_SUCCESS)
                                {
                                    ProFitData.gFRWKSVC.SysLog("Error returned from lActivateForm", LogLevel.logDebug3);
                                    ProFitData.gFRWKSVC.SysLog("lStatus: " + lStatus.ToString(), LogLevel.logDebug3);
                                }
                            }
                            break;

                        case "BESEARCH":
                            switch (Convert.ToString(roMsg.Variable1))
                            {
                                case "CANCEL":
                                    //the user closed the form
                                    mCurForm.cmdBESearch.Enabled = true;
                                    break;

                                case "COMPLETE":
                                    //we are ready to go get the data
                                    lStatus = mCurForm.lGetSearchData(Convert.ToString(roMsg.Variable2));
                                    if (lStatus != ProFitData.PFT_SUCCESS)
                                    {
                                        ProFitData.gFRWKSVC.SysLog("Error returned from mCurForm.lGetSearchData", LogLevel.logDebug3);
                                        ProFitData.gFRWKSVC.SysLog("lStatus: " + lStatus.ToString(), LogLevel.logDebug3);
                                    }
                                    break;

                                case "ERROR":
                                    //there was an error returned from the search
                                    mCurForm.cmdBESearch.Enabled = true;
                                    break;

                                default:
                                    break;
                            }
                            break;

                        default:
                            break;
                    }
                }

                //if we get here, we have succeeded
                result = ProFitData.PFT_SUCCESS;
                //mParent.lPopulateStatementInfo (abeid)
                ProFitData.gFRWKSVC.SysLog("CCollectionViewExit", LogLevel.logAudit2);
                return result;
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);

                ProFitData.gFRWKSVC.SysLog("CCollectionViewError", LogLevel.logAudit2);
                //    MsgBox i18nGetMessage(msModule_Name, "108", gino_index, "Invalid Script Status"), vbCritical 'i18n
                Cursor.Current = Cursors.Default;
                result = ProFitData.PFT_FAILURE;

                return result;
            }
        }

        //Author:        Mandy Ossana
        //Purpose:       Handles the activation on the existing form
        //Written:       03-22-2000
        //Modifications:
        //0000           Mandy Ossana

        public int lActivateForm()
        {
            //We use the Windows API SetFocus to properly execute
            //the SetFocus method
            mCurForm.Focus();

            //set focus to the form
            int lRet = Convert.ToInt32(mCurForm.Focused);

            return lRet;
        }

        //Reference to the Implementation class.
        public CCollection Parent
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

        internal int disable_flg
        {
            get
            {
                return mData.disable_flg;
            }
            set
            {
                mData.disable_flg = value;
            }
        }

        internal string letter_line1
        {
            get
            {
                return mData.letter_line1;
            }
            set
            {
                mData.letter_line1 = value;
            }
        }

        internal string letter_line2
        {
            get
            {
                return mData.letter_line2;
            }
            set
            {
                mData.letter_line2 = value;
            }
        }

        internal string letter_line3
        {
            get
            {
                return mData.letter_line3;
            }
            set
            {
                mData.letter_line3 = value;
            }
        }

        internal string letter_line4
        {
            get
            {
                return mData.letter_line4;
            }
            set
            {
                mData.letter_line4 = value;
            }
        }

        internal string letter_line5
        {
            get
            {
                return mData.letter_line5;
            }
            set
            {
                mData.letter_line5 = value;
            }
        }

        internal string letter_line6
        {
            get
            {
                return mData.letter_line6;
            }
            set
            {
                mData.letter_line6 = value;
            }
        }

        internal string letter_line7
        {
            get
            {
                return mData.letter_line7;
            }
            set
            {
                mData.letter_line7 = value;
            }
        }

        internal string letter_line8
        {
            get
            {
                return mData.letter_line8;
            }
            set
            {
                mData.letter_line8 = value;
            }
        }

        internal string letter_line9
        {
            get
            {
                return mData.letter_line9;
            }
            set
            {
                mData.letter_line9 = value;
            }
        }

        internal double dunning_level_cd
        {
            get
            {
                return mData.DunningLevelCd;
            }
            set
            {
                mData.DunningLevelCd = value;
            }
        }

        internal string letter_line10
        {
            get
            {
                return mData.letter_line10;
            }
            set
            {
                mData.letter_line10 = value;
            }
        }

        internal string letter_line11
        {
            get
            {
                return mData.letter_line11;
            }
            set
            {
                mData.letter_line11 = value;
            }
        }

        internal string letter_line12
        {
            get
            {
                return mData.letter_line12;
            }
            set
            {
                mData.letter_line12 = value;
            }
        }

        internal string letter_line13
        {
            get
            {
                return mData.letter_line13;
            }
            set
            {
                mData.letter_line13 = value;
            }
        }

        internal string letter_line14
        {
            get
            {
                return mData.letter_line14;
            }
            set
            {
                mData.letter_line14 = value;
            }
        }

        internal string letter_line15
        {
            get
            {
                return mData.letter_line15;
            }
            set
            {
                mData.letter_line15 = value;
            }
        }

        //TL4790     08/11/00
        //Reference to the data class.
        public CCollectionData Data
        {
            get
            {
                return mData;
            }
            set
            {
                mData = value;
            }
        }

        public CCollectionView()
        {
            ProFitData.gFRWKSVC.SysLog("CTemplateView::Initialize", LogLevel.logDebug3); //   ///template
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                ProFitData.gFRWKSVC.SysLog("CTemplateView::Terminate", LogLevel.logDebug3); //   ///template

                if (mCurForm != null)
                {
                    mCurForm.Dispose();
                    mCurForm = null;
                }
                if (mParent != null)
                {
                    mParent.Dispose();
                    mParent = null;
                }
                if (mData != null)
                {
                    mData.Dispose();
                    mData = null;
                }
            }
        }

        //End TL4790 08/11/00
    }
}