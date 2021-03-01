namespace Cerner.PFT_COLLECTION_TOOL
{
    internal class ProFitData
    {
        //*******************************************************************
        //                     ProFitData Module
        //-------------------------------------------------------------------
        //This .BAS module holds Variables, constants, Enums, and Types which
        //are specific to the ProFit Application.
        //GAB Adding cTransAlias Icon  9/16/1999
        //GAB Adding PFT_DATA_FAILURE 12/9/1999

        //Event logging can happen with this guy
        //Public EventLog As CEventLog

        //*****************************************
        // Global Framework Service Object
        static private PFTFramework.CFRWKSVC _gFRWKSVC = null;

        static public PFTFramework.CFRWKSVC gFRWKSVC
        {
            get
            {
                if (_gFRWKSVC == null)
                {
                    _gFRWKSVC = new PFTFramework.CFRWKSVC();
                }
                return _gFRWKSVC;
            }
            set
            {
                _gFRWKSVC = value;
            }
        }

        //*****************************************
        // Image lists and Icon
        //Hard - coded:
        public const string COLLECTIONS_ICON = "imgCollections";

        //Max retries for DB Access
        public const int MAX_RETRIES = 3;

        public const double CURRENCY_TYPE = 18934;
        public const double TRANS_TYPE = 18649;
        public const double TRANS_SUB_TYPE = 20549;
        public const double TRANS_STATUS = 18938;
        public const double TRANS_STATUS_REASON = 20569;
        public const double DIST_METHOD = 18732;
        public const double PMT_REASON = 18937;

        //*****************************************
        //Error Handling Constants
        //Success
        public const int PFT_SUCCESS = 0;

        //Failure
        public const int PFT_FAILURE = 1;

        //Script Errors

        public const int PFT_SCRIPT_FAILURE = 33200;
        public const int PFT_SCRIPT_NO_REPLY = 33210;
        public const int PFT_SCRIPT_UNKNOWN_STATUS = 33211;
    }
}