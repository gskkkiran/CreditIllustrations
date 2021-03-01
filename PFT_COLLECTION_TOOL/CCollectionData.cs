using Cerner.ApplicationFramework.Middleware;
using Cerner.Foundations.Data;
using Cerner.Foundations.Middleware;
using Cerner.PFT_PatientAccountingReusable;
using Cerner.PFTFramework;
using System;
using System.Windows.Forms;

namespace Cerner.PFT_COLLECTION_TOOL
{
    internal class CCollectionData : IDisposable
    {
        private string sLetter_line1 = String.Empty;
        private string sLetter_line2 = String.Empty;
        private string sLetter_line3 = String.Empty;
        private string sLetter_line4 = String.Empty;
        private string sLetter_line5 = String.Empty;
        private string sLetter_line6 = String.Empty;
        private string sLetter_line7 = String.Empty;
        private string sLetter_line8 = String.Empty;
        private string sLetter_line9 = String.Empty;
        private string sLetter_line10 = String.Empty;
        private string sLetter_line11 = String.Empty;
        private string sLetter_line12 = String.Empty;
        private string sLetter_line13 = String.Empty;
        private string sLetter_line14 = String.Empty;
        private string sLetter_line15 = String.Empty;
        private CheckState lUptCnt = (CheckState)0;
        private CheckState ldisable_flg = (CheckState)0;
        private double Collection_letter_id = 0;
        private double dDunningLevelCd = 0;
        private double dBillingEntityID = 0; //TL4790 08/11/00

        //reference to the view class.
        //reference to the view class.
        internal CCollectionView Parent { get; set; }

        internal int disable_flg
        {
            get
            {
                return (int)ldisable_flg;
            }
            set
            {
                if (Enum.IsDefined(typeof(CheckState), value))
                {
                    ldisable_flg = (CheckState)value;
                }
            }
        }

        internal string letter_line1
        {
            get
            {
                return sLetter_line1;
            }
            set
            {
                sLetter_line1 = value;
            }
        }

        internal string letter_line2
        {
            get
            {
                return sLetter_line2;
            }
            set
            {
                sLetter_line2 = value;
            }
        }

        internal string letter_line3
        {
            get
            {
                return sLetter_line3;
            }
            set
            {
                sLetter_line3 = value;
            }
        }

        internal string letter_line4
        {
            get
            {
                return sLetter_line4;
            }
            set
            {
                sLetter_line4 = value;
            }
        }

        internal string letter_line5
        {
            get
            {
                return sLetter_line5;
            }
            set
            {
                sLetter_line5 = value;
            }
        }

        internal string letter_line6
        {
            get
            {
                return sLetter_line6;
            }
            set
            {
                sLetter_line6 = value;
            }
        }

        internal string letter_line7
        {
            get
            {
                return sLetter_line7;
            }
            set
            {
                sLetter_line7 = value;
            }
        }

        internal string letter_line8
        {
            get
            {
                return sLetter_line8;
            }
            set
            {
                sLetter_line8 = value;
            }
        }

        internal string letter_line9
        {
            get
            {
                return sLetter_line9;
            }
            set
            {
                sLetter_line9 = value;
            }
        }

        internal string letter_line10
        {
            get
            {
                return sLetter_line10;
            }
            set
            {
                sLetter_line10 = value;
            }
        }

        internal string letter_line11
        {
            get
            {
                return sLetter_line11;
            }
            set
            {
                sLetter_line11 = value;
            }
        }

        internal string letter_line12
        {
            get
            {
                return sLetter_line12;
            }
            set
            {
                sLetter_line12 = value;
            }
        }

        internal string letter_line13
        {
            get
            {
                return sLetter_line13;
            }
            set
            {
                sLetter_line13 = value;
            }
        }

        internal string letter_line14
        {
            get
            {
                return sLetter_line14;
            }
            set
            {
                sLetter_line14 = value;
            }
        }

        internal string letter_line15
        {
            get
            {
                return sLetter_line15;
            }
            set
            {
                sLetter_line15 = value;
            }
        }

        internal double DunningLevelCd
        {
            get
            {
                return dDunningLevelCd;
            }
            set
            {
                dDunningLevelCd = value;
            }
        }

        //TL4790     08/11/00
        internal double BillingEntityID
        {
            get
            {
                return dBillingEntityID;
            }
            set
            {
                dBillingEntityID = value;
            }
        }

        public CCollectionData()
        {
            ProFitData.gFRWKSVC.SysLog("CCollectionData::Initialize", LogLevel.logDebug3);
        }

        //End TL4790 08/11/00
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                //logs the collection termination
                ProFitData.gFRWKSVC.SysLog("CCollectionData::Terminate", LogLevel.logDebug3);
            }
        }

        internal int lAddCollection()
        {
            int result = 0;
            Index TargetObjectValue_index = new Index("TargetObjectValue");
            Index TargetObjectName_index = new Index("TargetObjectName");
            Index operationStatus_index = new Index("operationStatus");
            Index operationname_index = new Index("operationname");
            Index subeventstatus_index = new Index("subeventstatus");
            Index subeventstatus_index2 = new Index("subeventstatus");
            Index status_index = new Index("status");
            Index status_data_index = new Index("status_data");
            Index status_data_index2 = new Index("status_data");
            Index letter_line15_index = new Index("letter_line15");
            Index letter_line14_index = new Index("letter_line14");
            Index letter_line13_index = new Index("letter_line13");
            Index letter_line12_index = new Index("letter_line12");
            Index letter_line11_index = new Index("letter_line11");
            Index letter_line10_index = new Index("letter_line10");
            Index letter_line9_index = new Index("letter_line9");
            Index letter_line8_index = new Index("letter_line8");
            Index letter_line7_index = new Index("letter_line7");
            Index letter_line6_index = new Index("letter_line6");
            Index letter_line5_index = new Index("letter_line5");
            Index letter_line4_index = new Index("letter_line4");
            Index letter_line3_index = new Index("letter_line3");
            Index letter_line2_index = new Index("letter_line2");
            Index letter_line1_index = new Index("letter_line1");
            Index lDisableFlg_index = new Index("lDisableFlg");
            Index lUpdtCnt_index = new Index("lUpdtCnt");
            Index ActiveInd_index = new Index("ActiveInd");
            Index collection_letter_id_index = new Index("collection_letter_id");
            Index be_id_index = new Index("be_id");
            Index dunning_level_cd_index = new Index("dunning_level_cd");
            ProFitData.gFRWKSVC.SysLog("CCollectionData::lAddCollection:Start", LogLevel.logAudit2);
            CrmBasicJob job = null;
            Instance lhReqStruct = null;
            Instance lhReply = null;
            Instance lhStatusBlock = null;
            string sStatus = String.Empty;
            int nTries = 0;
            bool nCrmStatus = false;

            //Change management
            using (var dmDcm = new DmDcmHelper { GetDetailData = CCollection.UnitOfWorkDetailData })
            {
                int lUniqueId = CrmAccessDlg.GetInstance().BeginScript(4053060, 4053061, "lAddCollection");
                try
                {
                    if (lUniqueId == (int)CrmAccessDlg.PerformStatus.BadId)
                    {
                        return result;
                    }
                    result = ProFitData.PFT_FAILURE;
                    //get the IDs of the Task and Request
                    //4053060
                    //4053061

                    //start the task
                    ProFitData.gFRWKSVC.lBeginScript(ref job, 4053060, 4053061);
                    if (job == null)
                    {
                        return ProFitData.PFT_FAILURE;
                    }

                    //get a handle to the request structure
                    lhReqStruct = job.Request;
                    if (lhReqStruct == null)
                    {
                        ProFitData.gFRWKSVC.SysLog("invalid request structure handle.", LogLevel.logDebug3);
                        return ProFitData.PFT_FAILURE;
                    }

                    lhReqStruct.SetDouble(dunning_level_cd_index, dDunningLevelCd);

                    //TL4790     08/11/00
                    lhReqStruct.SetDouble(be_id_index, dBillingEntityID);

                    //End TL4790 08/11/00

                    //    lstatus = SrvSetDouble(lhReqStruct, "collection_letter_id", -1)
                    lhReqStruct.SetDouble(collection_letter_id_index, Collection_letter_id);

                    lhReqStruct.SetShort(ActiveInd_index, 1);

                    lhReqStruct.SetInt(lUpdtCnt_index, Convert.ToInt32(lUptCnt));

                    lhReqStruct.SetInt(lDisableFlg_index, Convert.ToInt32(ldisable_flg));

                    lhReqStruct.SetString(letter_line1_index, sLetter_line1);

                    lhReqStruct.SetString(letter_line2_index, sLetter_line2);

                    lhReqStruct.SetString(letter_line3_index, sLetter_line3);

                    lhReqStruct.SetString(letter_line4_index, sLetter_line4);

                    lhReqStruct.SetString(letter_line5_index, sLetter_line5);

                    lhReqStruct.SetString(letter_line6_index, sLetter_line6);

                    lhReqStruct.SetString(letter_line7_index, sLetter_line7);

                    lhReqStruct.SetString(letter_line8_index, sLetter_line8);

                    lhReqStruct.SetString(letter_line9_index, sLetter_line9);

                    lhReqStruct.SetString(letter_line10_index, sLetter_line10);

                    lhReqStruct.SetString(letter_line11_index, sLetter_line11);

                    lhReqStruct.SetString(letter_line12_index, sLetter_line12);

                    lhReqStruct.SetString(letter_line13_index, sLetter_line13);

                    lhReqStruct.SetString(letter_line14_index, sLetter_line14);

                    lhReqStruct.SetString(letter_line15_index, sLetter_line15);

                    //Change management
                    CCollection.DetailData = string.Format("{0}, {1}, {2},{3}", "Dunning level cd: " + dDunningLevelCd, "Billing Entity Id: " + dBillingEntityID, "Collection letter id: " + Collection_letter_id, "Disable flg: " + Convert.ToBoolean(Convert.ToInt32(ldisable_flg)));
                    dmDcm.PerformStartUnitOfWork("lAddCollection");

                    //perform the script until it works or we exceed threshold
                    nTries = 0;
                    do
                    {
                        nCrmStatus = job.Perform();
                        nTries++;
                    }
                    while (!(nTries >= ProFitData.MAX_RETRIES || nCrmStatus));

                    //get the handle to the reply structure
                    lhReply = job.Reply;
                    if (lhReply == null)
                    {
                        //0 is an invalid handle
                        ProFitData.gFRWKSVC.SysLog("CCollectionData::lCollectionData: Reply handle is 0", LogLevel.logDebug3);
                        return ProFitData.PFT_FAILURE;
                    }
                    //get handle to the status block of the script
                    lhStatusBlock = lhReply.GetStruct(status_data_index);
                    if (lhStatusBlock == null)
                    {
                        //0 is an invalid handle
                        ProFitData.gFRWKSVC.SysLog("CCollectionData::lAddCollection - SrvGetStruct failed, handle = 0", LogLevel.logDebug3);
                        return ProFitData.PFT_FAILURE;
                    }

                    //get the status of the script
                    sStatus = lhStatusBlock.GetString(status_index);

                    //evaluate the status
                    Instance lhItemEvent = null;
                    int x = 0;
                    switch (sStatus)
                    {
                        case "S":
                        case "s":  //success
                            ProFitData.gFRWKSVC.SysLog("CCollectionData::lAddCollection - Script returned (S)uccess", LogLevel.logDebug3);
                            break;

                        case "Z":
                        case "z":
                            ProFitData.gFRWKSVC.SysLog("lRemove script returned no records", LogLevel.logDebug3);
                            result = ProFitData.PFT_SCRIPT_NO_REPLY;
                            return result;

                        case "F":
                        case "f":

                            lhStatusBlock = lhReply.GetStruct(status_data_index2);
                            if (lhStatusBlock == null)
                            {
                                ProFitData.gFRWKSVC.SysLog("Invalid item handle returned from the database", LogLevel.logDebug3);
                                ProFitData.gFRWKSVC.SysLog("hList: " + lhStatusBlock.ToString(), LogLevel.logDebug3);
                                return ProFitData.PFT_FAILURE;
                            }
                            x = 0;
                            lhItemEvent = lhStatusBlock.GetList(subeventstatus_index, x);
                            if (lhItemEvent == null)
                            {
                                do
                                {
                                    ProFitData.gFRWKSVC.SysLog("Count = " + x.ToString(), LogLevel.logTrace4);
                                    ProFitData.gFRWKSVC.SysLog("operationname = " + lhItemEvent.GetString(operationname_index), LogLevel.logTrace4);
                                    ProFitData.gFRWKSVC.SysLog("operationStatus = " + lhItemEvent.GetString(operationStatus_index), LogLevel.logTrace4);
                                    ProFitData.gFRWKSVC.SysLog("TargetObjectName = " + lhItemEvent.GetString(TargetObjectName_index), LogLevel.logTrace4);
                                    ProFitData.gFRWKSVC.SysLog("TargetObjectValue = " + lhItemEvent.GetString(TargetObjectValue_index), LogLevel.logTrace4);
                                    x++;
                                    lhItemEvent = lhStatusBlock.GetList(subeventstatus_index2, x);
                                }
                                while (lhItemEvent != null);
                            }

                            result = ProFitData.PFT_FAILURE;
                            return result;

                        default:
                            ProFitData.gFRWKSVC.SysLog("lRemove script unknown error", LogLevel.logDebug3);
                            result = ProFitData.PFT_SCRIPT_UNKNOWN_STATUS;
                            return result;
                    }

                    //return success to the calling function
                    result = ProFitData.PFT_SUCCESS;

                    //log normal termination
                    ProFitData.gFRWKSVC.SysLog("CCollectionData::lAddCollection - Normal Termination", LogLevel.logAudit2);

                    return result;
                }
                catch (System.Exception _exception_)
                {
                    Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);

                    if (result == ProFitData.PFT_SUCCESS)
                    {
                        result = ProFitData.PFT_FAILURE;
                    }
                    //log abnormal termination
                    ProFitData.gFRWKSVC.SysLog("CCollectionData::lRemove - abnormal termination", LogLevel.logAudit2);

                    //clear the vb err object
                    //dump procedure level variables
                    ProFitData.gFRWKSVC.SysLog(" gfrwksvc.happ: " + ProFitData.gFRWKSVC.happ.ToString(), LogLevel.logTrace4);
                    ProFitData.gFRWKSVC.SysLog("lTask: " + "4053060", LogLevel.logTrace4);
                    ProFitData.gFRWKSVC.SysLog(" lRequest: " + "4053061", LogLevel.logTrace4);
                    return result;
                }
                finally
                {
                    if (job != null)
                    {
                        job.Dispose();
                        job = null;
                    }
                    if (lhReply != null)
                    {
                        lhReply.Dispose();
                        lhReply = null;
                    }
                    if (lhReqStruct != null)
                    {
                        lhReqStruct.Dispose();
                        lhReqStruct = null;
                    }
                    if (lhStatusBlock != null)
                    {
                        lhStatusBlock.Dispose();
                        lhStatusBlock = null;
                    }

                    ////Change management
                    CrmAccessDlg.GetInstance().EndScript(lUniqueId);
                    dmDcm.PerformStopUnitOfWork();
                }
            }
        }

        //001    TL4790  08/11/00    Added Billing Entity
        internal int lGetCollectionInfo()
        {
            int result = 0;
            Index collection_letter_id_index = new Index("collection_letter_id");
            Index letter_line15_index = new Index("letter_line15");
            Index letter_line14_index = new Index("letter_line14");
            Index letter_line13_index = new Index("letter_line13");
            Index letter_line12_index = new Index("letter_line12");
            Index letter_line11_index = new Index("letter_line11");
            Index letter_line10_index = new Index("letter_line10");
            Index letter_line9_index = new Index("letter_line9");
            Index letter_line8_index = new Index("letter_line8");
            Index letter_line7_index = new Index("letter_line7");
            Index letter_line6_index = new Index("letter_line6");
            Index letter_line5_index = new Index("letter_line5");
            Index letter_line4_index = new Index("letter_line4");
            Index letter_line3_index = new Index("letter_line3");
            Index letter_line2_index = new Index("letter_line2");
            Index letter_line1_index = new Index("letter_line1");
            Index status_index = new Index("status");
            Index status_data_index = new Index("status_data");
            Index be_id_index = new Index("be_id");
            Index dunning_level_cd_index = new Index("dunning_level_cd");

            ProFitData.gFRWKSVC.SysLog("CCollectionData::lGetCollectionInfo:Start", LogLevel.logAudit2);

            CrmBasicJob job = null;
            Instance lhReqStruct = null;
            Instance lhReply = null;
            Instance lhItem = null;
            string sStatus = String.Empty;
            //Dim dDunningCd      As Double
            int nTries = 0;
            bool nCrmStatus = false; //return status of Crm Calls
            
            try
            {
                ////////////////////// Standard CCL Fields//////////////////////////////
                //Procedure level Variables

                //Standard crm handles //handle to the task //handle to the request //handle to the request structure //handle to the Reply

                //create request/reply structures and returns request handle
                ProFitData.gFRWKSVC.lBeginScript(ref job, 4053060, 4053060);
                if (job == null)
                {
                    ProFitData.gFRWKSVC.SysLog("CCollectionData::lGetCollectionInfo - Error starting task", LogLevel.logDebug3);
                    return ProFitData.PFT_FAILURE;
                }

                //get a handle to the Request structure
                lhReqStruct = job.Request;// GetRequest();
                if (lhReqStruct == null)
                {
                    ProFitData.gFRWKSVC.SysLog("CCollectionData::lGetCollectionInfo - invalid Request handle.", LogLevel.logDebug3);
                    return ProFitData.PFT_FAILURE;
                }
                //populate the request structure
                lhReqStruct.SetDouble(dunning_level_cd_index, dDunningLevelCd);

                //TL4790     08/11/00
                lhReqStruct.SetDouble(be_id_index, dBillingEntityID);

                //End TL4790 08/11/00

                //perform the script until it works or we exceed threshold
                nTries = 0;
                do
                {
                    nCrmStatus = job.Perform();
                    nTries++;
                }
                while (!(nTries >= ProFitData.MAX_RETRIES || nCrmStatus));

                //get the handle to the Reply Structure
                lhReply = job.Reply;
                if (lhReply == null)
                {
                    //0 is an invalid  handle
                    ProFitData.gFRWKSVC.SysLog("CCollectionData::lGetCollectionInfo: Reply Handle is 0", LogLevel.logDebug3);
                    return ProFitData.PFT_FAILURE;
                }

                //get a handle to the status block of the script
                lhItem = lhReply.GetStruct(status_data_index);
                if (lhItem == null)
                {
                    //0 is an invalid handle
                    ProFitData.gFRWKSVC.SysLog("CStatmentData::lGetCollectionInfo - SrvGetStruct failed, handle = 0", LogLevel.logDebug3);
                    return ProFitData.PFT_FAILURE;
                }

                //get the status of the script
                sStatus = lhItem.GetString(status_index);

                //evaluate the status
                switch (sStatus)
                {
                    case "S":
                    case "s":  //success
                        ProFitData.gFRWKSVC.SysLog("CCollectionData::lGetCollectionInfo - Script returned (S)uccess", LogLevel.logDebug3);
                        sLetter_line1 = lhReply.GetString(letter_line1_index);
                        sLetter_line2 = lhReply.GetString(letter_line2_index);
                        sLetter_line3 = lhReply.GetString(letter_line3_index);
                        sLetter_line4 = lhReply.GetString(letter_line4_index);
                        sLetter_line5 = lhReply.GetString(letter_line5_index);
                        sLetter_line6 = lhReply.GetString(letter_line6_index);
                        sLetter_line7 = lhReply.GetString(letter_line7_index);
                        sLetter_line8 = lhReply.GetString(letter_line8_index);
                        sLetter_line9 = lhReply.GetString(letter_line9_index);
                        sLetter_line10 = lhReply.GetString(letter_line10_index);
                        sLetter_line11 = lhReply.GetString(letter_line11_index);
                        sLetter_line12 = lhReply.GetString(letter_line12_index);
                        sLetter_line13 = lhReply.GetString(letter_line13_index);
                        sLetter_line14 = lhReply.GetString(letter_line14_index);
                        sLetter_line15 = lhReply.GetString(letter_line15_index);
                        Collection_letter_id = lhReply.GetDouble(collection_letter_id_index);
                        break;

                    case "Z":
                    case "z":  //zero records returned
                        ProFitData.gFRWKSVC.SysLog("lGetCollectionInfo script returned no records", LogLevel.logDebug3);
                        result = ProFitData.PFT_SCRIPT_NO_REPLY;

                        sLetter_line1 = System.String.Empty;
                        sLetter_line2 = System.String.Empty;
                        sLetter_line3 = System.String.Empty;
                        sLetter_line4 = System.String.Empty;
                        sLetter_line5 = System.String.Empty;
                        sLetter_line6 = System.String.Empty;
                        sLetter_line7 = System.String.Empty;
                        sLetter_line8 = System.String.Empty;
                        sLetter_line9 = System.String.Empty;
                        sLetter_line10 = System.String.Empty;
                        sLetter_line11 = System.String.Empty;
                        sLetter_line12 = System.String.Empty;
                        sLetter_line13 = System.String.Empty;
                        sLetter_line14 = System.String.Empty;
                        sLetter_line15 = System.String.Empty;
                        disable_flg = 0;
                        return result;

                    case "F":
                    case "f":  //script failed
                        ProFitData.gFRWKSVC.SysLog("lGetCollectionInfo script failed", LogLevel.logDebug3);
                        result = ProFitData.PFT_SCRIPT_FAILURE;
                        return ProFitData.PFT_FAILURE;

                    default:
                        ProFitData.gFRWKSVC.SysLog("lGetCollectionInfo script unknown error", LogLevel.logDebug3);
                        result = ProFitData.PFT_SCRIPT_UNKNOWN_STATUS;
                        return result;
                }

                //set return value
                result = ProFitData.PFT_SUCCESS;
                ProFitData.gFRWKSVC.SysLog("cCollectionData::lGetCollectionInfo:Normal Termination", LogLevel.logAudit2);
                return result;
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);

                //error routine
                ProFitData.gFRWKSVC.SysLog("cCollectionData::lGetCollectionInfo:Error", LogLevel.logAudit2);

                if (ProFitData.gFRWKSVC.Level == 4)
                {
                    //dump variables
                    ProFitData.gFRWKSVC.SysLog("lhReqStruct: " + lhReqStruct.ToString(), LogLevel.logTrace4);
                    ProFitData.gFRWKSVC.SysLog("lhReply: " + lhReply.ToString(), LogLevel.logTrace4);
                    ProFitData.gFRWKSVC.SysLog("lhItem: " + lhItem.ToString(), LogLevel.logTrace4);
                    ProFitData.gFRWKSVC.SysLog("sStatus: " + sStatus, LogLevel.logTrace4);
                    ProFitData.gFRWKSVC.SysLog("lTask: " + "4053060", LogLevel.logTrace4);
                    ProFitData.gFRWKSVC.SysLog("lreq: " + "4053060", LogLevel.logTrace4);
                }
                return result;
            }
            finally
            {
                if (job != null)
                {
                    job.Dispose();
                    job = null;
                }
                if (lhItem != null)
                {
                    lhItem.Dispose();
                    lhItem = null;
                }
                if (lhReply != null)
                {
                    lhReply.Dispose();
                    lhReply = null;
                }
                if (lhReqStruct != null)
                {
                    lhReqStruct.Dispose();
                    lhReqStruct = null;
                }
            }
        }
    }
}