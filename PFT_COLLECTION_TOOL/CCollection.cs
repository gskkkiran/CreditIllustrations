using Cerner.PFTFramework;
using System;

namespace Cerner.PFT_COLLECTION_TOOL
{
    public class CCollection : IDisposable
    {
        private PFTFramework.CClassInfo _mClassInfo = null;

        private PFTFramework.CClassInfo mClassInfo
        {
            get
            {
                return _mClassInfo;
            }
            set
            {
                if (_mClassInfo != value)
                {
                    if (_mClassInfo != null)
                    {
                        this.mClassInfo.EvntMessage -= new PFTFramework.EvntMessageHandler(this.mClassInfo_EvntMessage);
                    }
                    _mClassInfo = value;
                    if (_mClassInfo != null)
                    {
                        this.mClassInfo.EvntMessage += new PFTFramework.EvntMessageHandler(this.mClassInfo_EvntMessage);
                    }
                }
            }
        }

        //Change Management

        internal static string DetailData { get; set; }

        internal static string UnitOfWorkDetailData(object o, EventArgs e)
        {
            return DetailData;
        }

        private CCollectionView mView = null;
        private CCollectionData mData = null;

        public PFTFramework.CClassInfo ClassInfo
        {
            get
            {
                return mClassInfo;
            }
            set
            {
                mClassInfo = value;
            }
        }       

        public object Parent
        {
            get;
            set;
        }//reference to calling object

        public int lShowForm()
        {
            mView = new CCollectionView();
            int lStatus = mView.lShowForm();
            return lStatus;
        }

        //Refer to the CMessage class for details about receiving
        //messages. This function is vital for receiving special
        //instructions from the Framework and other classes. It
        //receives a CMessage object, and optionally returns
        //a CMessage object.
        public int Message(PFTFramework.CMessage oMsg)
        {
            int result = ProFitData.PFT_FAILURE;
            //initialize the error handler
            try
            {
                //logs the entry into this method
                ProFitData.gFRWKSVC.SysLog("CCollection::Message - Entry", LogLevel.logAudit2);
                int lStatus = 0;

                //determines what action is required based on the type of message
                //being sent to this object from the frameworks message services
                switch (oMsg.MessageType)
                {
                    case eMessageType.MSG_CREATE:
                        //We can set up any additional info here
                        //if we need too. In this case, we set up
                        //our IconText and PanelText properties.
                        ClassInfo.IconText = ResourceHandler.Resources.GetString("1475"); //i18n
                        ClassInfo.PanelText = ResourceHandler.Resources.GetString("1475"); //i18n

                        //Now we add our icon to the Navigation bar
                        //(optional)
                        ClassInfo.AddIconToNavBar();
                        lStatus = Convert.ToInt32(Cerner.ApplicationFramework.ConversionSupport.Utils.ReflectionHelper.Invoke(Parent, "lAddIconToTvw", new object[] { mClassInfo }));

                        //This message is sent from the Framework, telling
                        //us that the Framework is being shut down, and we
                        //need to clean up our resources.
                        break;

                    case eMessageType.MSG_DESTROY:
                        if (mView != null)
                        {
                            //we don't have a view, so don't worry about it
                            mView.lShutDownFromParent();
                            //we can release our view reference
                            mView = null;
                            mClassInfo = null;
                        }
                        //message is sent to tell us that we have been clicked
                        break;

                    case eMessageType.MSG_CLICK:

                        if (mView == null)
                        {
                            //we don't have a view, so make one
                            lStatus = lShowView();

                            if (lStatus != ProFitData.PFT_SUCCESS)
                            {
                                //Message the user that there has been a problem in creating the form.
                            }
                        }

                        //Activate the form associated with the view
                        mView.lActivateForm();
                        break;                   

                    case eMessageType.MSG_NOTIFY:
                        //figure out who is notifying us
                        //TL4790
                        if (string.Compare(Convert.ToString(oMsg.Variable2), "BESEARCH", true) == 0)
                        {
                            lStatus = mView.lMessageReply(oMsg);
                            if (lStatus != ProFitData.PFT_SUCCESS)
                            {
                                ProFitData.gFRWKSVC.SysLog("Error returned from mView:lMessageReply", LogLevel.logDebug3);
                                ProFitData.gFRWKSVC.SysLog("lRet: " + lStatus.ToString(), LogLevel.logDebug3);
                            }
                        }
                        else
                        {
                        }
                        //End TL4790
                        break;

                    default:
                        break;
                }
                //normal termination
                ProFitData.gFRWKSVC.SysLog("CCollection::Message - Normal Termination", LogLevel.logAudit2);

                //returns the normal termination of this method
                return ProFitData.PFT_SUCCESS;
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);

                //ensures the function returns an error status
                if (result == ProFitData.PFT_SUCCESS)
                {
                    result = ProFitData.PFT_FAILURE;
                }

                //abnormal termination
                ProFitData.gFRWKSVC.SysLog("CCollection::Message - Abnormal Termination", LogLevel.logAudit2);

                return result;
            }
        }

        // Purpose:  This function creates a new View object and calls its ShowForm method.
        // Author:   N/A - Framework template function
        // Written:  N/A
        // Modification Log
        // 001       04/27/1999      JG2596      Added Error handler and SysLog stuff

        public int lShowView()
        {
            //initialize the error handler routine
            int result = ProFitData.PFT_FAILURE;
            try
            {
                //log entry into ShowView method
                ProFitData.gFRWKSVC.SysLog("CCollection::lShowView - Entry", LogLevel.logAudit2);

                //Procedure level variables
                int lStatus = 0;

                //Instantiate the View and set its Parent
                mView = new CCollectionView();
                mView.Parent = this;

                lStatus = mView.lShowForm();

                if (lStatus != ProFitData.PFT_SUCCESS)
                {
                    //log the failure of the ShowForm call
                    ProFitData.gFRWKSVC.SysLog("CCollection::lShowView - mView.lShowForm failed", LogLevel.logDebug3);
                    ProFitData.gFRWKSVC.SysLog("CCollection::lShowView - lStatus:  " + lStatus.ToString(), LogLevel.logDebug3);

                    //set return value to status
                    result = lStatus;

                    //send control to error handler
                    return result;
                }

                //log a normal termination
                ProFitData.gFRWKSVC.SysLog("CCollection::lShowView - Normal Termination", LogLevel.logAudit2);

                //return a normal termination state

                return ProFitData.PFT_SUCCESS;
            }
            catch (System.Exception _exception_)
            {
                Cerner.Foundations.Logging.ExceptionReporting.ReportException(_exception_);

                //ensure the function returns error status
                if (result == ProFitData.PFT_SUCCESS)
                {
                    result = ProFitData.PFT_FAILURE;
                }

                //log abnormal termination
                ProFitData.gFRWKSVC.SysLog("CCollection::lShowView - Abnormal Termination", LogLevel.logAudit2);

                return result;
            }
        }

        //***       ReleaseView
        //Called by the View object. Informs this class that the
        //view is going away, so this class must release its
        public int ReleaseView()
        {
            int result = ProFitData.PFT_FAILURE;
            //init error handler
            try
            {
                //log entrance
                ProFitData.gFRWKSVC.SysLog("CCollection::lReleaseView - Entrance", LogLevel.logAudit2);

                Cerner.ApplicationFramework.ConversionSupport.Utils.ReflectionHelper.Invoke(Parent, "lRemoveFromFolder", new object[] { this });

                //log a success
                ProFitData.gFRWKSVC.SysLog("CStatement::lReleaseView = normal termination", LogLevel.logAudit2);

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
                ProFitData.gFRWKSVC.SysLog("CCollection::lReleaseView - Abnormal Termination", LogLevel.logAudit2);

                return result;
            }
            finally
            {
                //cleanup code
                mView = null;
            }
        }

        //Author:    Mandy Ossana
        //Purpose:   Handles all the initialization needs for this class
        //Written:   03-22-2000
        //Modifications:
        //000    MV4772              Initial release
        public CCollection()
        {
            //logs this collection initialization
            ProFitData.gFRWKSVC.SysLog("CCollection::Initialize", LogLevel.logAudit2);

            //instantiates the module level information class
            mClassInfo = new PFTFramework.CClassInfo();

            //Set some default parameters

            //We will be an object of type "CTemplate".
            //This is our Name.
            ClassInfo.Name = "CCollection";

            //We go in a folder called "Templates" when
            //our icon is displayed.
            //(optional)
            ClassInfo.FolderText = ResourceHandler.Resources.GetString("1475"); //   ///template 'i18n

            //Our icon is the Template Icon.
            //(optional)
            ClassInfo.IconKey = ProFitData.COLLECTIONS_ICON;

            ClassInfo.IconText = ResourceHandler.Resources.GetString("1475"); //i18n

            ClassInfo.PanelText = ResourceHandler.Resources.GetString("1475"); //i18n

            ClassInfo.IconDisplay();
        }

        //Author:    Mandy Ossana
        //Purpose:   Handles all the termination cleanup for this class
        //Written:   03-22-2000
        //Modifications:
        //000    MV4772              Initial release
        //

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
                ProFitData.gFRWKSVC.SysLog("CCollectin::Terminate", LogLevel.logAudit2);

                //tell framework to release the ClassInfo
                mClassInfo.lRelease();

                //clean up code - dereference all module level collections/arrays/collections

                if (mClassInfo != null)
                {
                    mClassInfo.Dispose();
                    mClassInfo = null;
                }
                if (mView != null)
                {
                    mView.Dispose();
                    mView = null;
                }
                if (mData != null)
                {
                    mData.Dispose();
                    mData = null;
                }
                if (Parent != null)
                {
                    Parent = null;
                }
            }
        }

        //This Event is raised from the mClassInfo object.  As other objects
        //send message, this event will receive the event and then pass the oMsg object
        //to the Message function
        private void mClassInfo_EvntMessage(ref  PFTFramework.CMessage oMsg)
        {
            Message(oMsg);
        }
    }
}