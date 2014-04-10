//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 4/10/2014 4:09:08 AM
namespace Demo.DataAccess.ConsoleUI.CBO_GlobalEntities
{
    
    /// <summary>
    /// There are no comments for Container in the schema.
    /// </summary>
    public partial class Container : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Container(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("Demo.DataAccess.Core.Models", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("Demo.DataAccess.ConsoleUI.CBO_GlobalEntities", typeName.Substring(27)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("Demo.DataAccess.ConsoleUI.CBO_GlobalEntities", global::System.StringComparison.Ordinal))
            {
                return string.Concat("Demo.DataAccess.Core.Models.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for APCFEEs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<APCFEE> APCFEEs
        {
            get
            {
                if ((this._APCFEEs == null))
                {
                    this._APCFEEs = base.CreateQuery<APCFEE>("APCFEEs");
                }
                return this._APCFEEs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<APCFEE> _APCFEEs;
        /// <summary>
        /// There are no comments for APCFEEDs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<APCFEED> APCFEEDs
        {
            get
            {
                if ((this._APCFEEDs == null))
                {
                    this._APCFEEDs = base.CreateQuery<APCFEED>("APCFEEDs");
                }
                return this._APCFEEDs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<APCFEED> _APCFEEDs;
        /// <summary>
        /// There are no comments for APCFEEs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToAPCFEEs(APCFEE aPCFEE)
        {
            base.AddObject("APCFEEs", aPCFEE);
        }
        /// <summary>
        /// There are no comments for APCFEEDs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToAPCFEEDs(APCFEED aPCFEED)
        {
            base.AddObject("APCFEEDs", aPCFEED);
        }
    }
    /// <summary>
    /// There are no comments for Demo.DataAccess.Core.Models.APCFEE in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SYSKEY
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("APCFEEs")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("SYSKEY")]
    public partial class APCFEE : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new APCFEE object.
        /// </summary>
        /// <param name="sYSKEY">Initial value of SYSKEY.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static APCFEE CreateAPCFEE(string sYSKEY)
        {
            APCFEE aPCFEE = new APCFEE();
            aPCFEE.SYSKEY = sYSKEY;
            return aPCFEE;
        }
        /// <summary>
        /// There are no comments for Property SYSKEY in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SYSKEY
        {
            get
            {
                return this._SYSKEY;
            }
            set
            {
                this.OnSYSKEYChanging(value);
                this._SYSKEY = value;
                this.OnSYSKEYChanged();
                this.OnPropertyChanged("SYSKEY");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SYSKEY;
        partial void OnSYSKEYChanging(string value);
        partial void OnSYSKEYChanged();
        /// <summary>
        /// There are no comments for Property NAME in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string NAME
        {
            get
            {
                return this._NAME;
            }
            set
            {
                this.OnNAMEChanging(value);
                this._NAME = value;
                this.OnNAMEChanged();
                this.OnPropertyChanged("NAME");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _NAME;
        partial void OnNAMEChanging(string value);
        partial void OnNAMEChanged();
        /// <summary>
        /// There are no comments for Property MDATE in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string MDATE
        {
            get
            {
                return this._MDATE;
            }
            set
            {
                this.OnMDATEChanging(value);
                this._MDATE = value;
                this.OnMDATEChanged();
                this.OnPropertyChanged("MDATE");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _MDATE;
        partial void OnMDATEChanging(string value);
        partial void OnMDATEChanged();
        /// <summary>
        /// There are no comments for Property MTIME in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string MTIME
        {
            get
            {
                return this._MTIME;
            }
            set
            {
                this.OnMTIMEChanging(value);
                this._MTIME = value;
                this.OnMTIMEChanged();
                this.OnPropertyChanged("MTIME");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _MTIME;
        partial void OnMTIMEChanging(string value);
        partial void OnMTIMEChanged();
        /// <summary>
        /// There are no comments for Property MUSER in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string MUSER
        {
            get
            {
                return this._MUSER;
            }
            set
            {
                this.OnMUSERChanging(value);
                this._MUSER = value;
                this.OnMUSERChanged();
                this.OnPropertyChanged("MUSER");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _MUSER;
        partial void OnMUSERChanging(string value);
        partial void OnMUSERChanged();
        /// <summary>
        /// There are no comments for Property ACTIVE in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ACTIVE
        {
            get
            {
                return this._ACTIVE;
            }
            set
            {
                this.OnACTIVEChanging(value);
                this._ACTIVE = value;
                this.OnACTIVEChanged();
                this.OnPropertyChanged("ACTIVE");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ACTIVE;
        partial void OnACTIVEChanging(string value);
        partial void OnACTIVEChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Demo.DataAccess.Core.Models.APCFEED in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SYSKEY
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("APCFEEDs")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("SYSKEY")]
    public partial class APCFEED : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new APCFEED object.
        /// </summary>
        /// <param name="sYSKEY">Initial value of SYSKEY.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static APCFEED CreateAPCFEED(string sYSKEY)
        {
            APCFEED aPCFEED = new APCFEED();
            aPCFEED.SYSKEY = sYSKEY;
            return aPCFEED;
        }
        /// <summary>
        /// There are no comments for Property SYSKEY in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SYSKEY
        {
            get
            {
                return this._SYSKEY;
            }
            set
            {
                this.OnSYSKEYChanging(value);
                this._SYSKEY = value;
                this.OnSYSKEYChanged();
                this.OnPropertyChanged("SYSKEY");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SYSKEY;
        partial void OnSYSKEYChanging(string value);
        partial void OnSYSKEYChanged();
        /// <summary>
        /// There are no comments for Property APC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string APC
        {
            get
            {
                return this._APC;
            }
            set
            {
                this.OnAPCChanging(value);
                this._APC = value;
                this.OnAPCChanged();
                this.OnPropertyChanged("APC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _APC;
        partial void OnAPCChanging(string value);
        partial void OnAPCChanged();
        /// <summary>
        /// There are no comments for Property APC_DP in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string APC_DP
        {
            get
            {
                return this._APC_DP;
            }
            set
            {
                this.OnAPC_DPChanging(value);
                this._APC_DP = value;
                this.OnAPC_DPChanged();
                this.OnPropertyChanged("APC_DP");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _APC_DP;
        partial void OnAPC_DPChanging(string value);
        partial void OnAPC_DPChanged();
        /// <summary>
        /// There are no comments for Property PMT_RATE in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PMT_RATE
        {
            get
            {
                return this._PMT_RATE;
            }
            set
            {
                this.OnPMT_RATEChanging(value);
                this._PMT_RATE = value;
                this.OnPMT_RATEChanged();
                this.OnPropertyChanged("PMT_RATE");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PMT_RATE;
        partial void OnPMT_RATEChanging(string value);
        partial void OnPMT_RATEChanged();
        /// <summary>
        /// There are no comments for Property NAT_COINS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string NAT_COINS
        {
            get
            {
                return this._NAT_COINS;
            }
            set
            {
                this.OnNAT_COINSChanging(value);
                this._NAT_COINS = value;
                this.OnNAT_COINSChanged();
                this.OnPropertyChanged("NAT_COINS");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _NAT_COINS;
        partial void OnNAT_COINSChanging(string value);
        partial void OnNAT_COINSChanged();
        /// <summary>
        /// There are no comments for Property MIN_COINS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string MIN_COINS
        {
            get
            {
                return this._MIN_COINS;
            }
            set
            {
                this.OnMIN_COINSChanging(value);
                this._MIN_COINS = value;
                this.OnMIN_COINSChanged();
                this.OnPropertyChanged("MIN_COINS");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _MIN_COINS;
        partial void OnMIN_COINSChanging(string value);
        partial void OnMIN_COINSChanged();
        /// <summary>
        /// There are no comments for Property PAY_OUTLR in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PAY_OUTLR
        {
            get
            {
                return this._PAY_OUTLR;
            }
            set
            {
                this.OnPAY_OUTLRChanging(value);
                this._PAY_OUTLR = value;
                this.OnPAY_OUTLRChanged();
                this.OnPropertyChanged("PAY_OUTLR");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PAY_OUTLR;
        partial void OnPAY_OUTLRChanging(string value);
        partial void OnPAY_OUTLRChanged();
        /// <summary>
        /// There are no comments for Property CO_PCNT in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CO_PCNT
        {
            get
            {
                return this._CO_PCNT;
            }
            set
            {
                this.OnCO_PCNTChanging(value);
                this._CO_PCNT = value;
                this.OnCO_PCNTChanged();
                this.OnPropertyChanged("CO_PCNT");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CO_PCNT;
        partial void OnCO_PCNTChanging(string value);
        partial void OnCO_PCNTChanged();
        /// <summary>
        /// There are no comments for Property EFF_DATE in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string EFF_DATE
        {
            get
            {
                return this._EFF_DATE;
            }
            set
            {
                this.OnEFF_DATEChanging(value);
                this._EFF_DATE = value;
                this.OnEFF_DATEChanged();
                this.OnPropertyChanged("EFF_DATE");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _EFF_DATE;
        partial void OnEFF_DATEChanging(string value);
        partial void OnEFF_DATEChanged();
        /// <summary>
        /// There are no comments for Property APCFEE in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string APCFEE
        {
            get
            {
                return this._APCFEE;
            }
            set
            {
                this.OnAPCFEEChanging(value);
                this._APCFEE = value;
                this.OnAPCFEEChanged();
                this.OnPropertyChanged("APCFEE");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _APCFEE;
        partial void OnAPCFEEChanging(string value);
        partial void OnAPCFEEChanged();
        /// <summary>
        /// There are no comments for Property MDATE in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string MDATE
        {
            get
            {
                return this._MDATE;
            }
            set
            {
                this.OnMDATEChanging(value);
                this._MDATE = value;
                this.OnMDATEChanged();
                this.OnPropertyChanged("MDATE");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _MDATE;
        partial void OnMDATEChanging(string value);
        partial void OnMDATEChanged();
        /// <summary>
        /// There are no comments for Property MTIME in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string MTIME
        {
            get
            {
                return this._MTIME;
            }
            set
            {
                this.OnMTIMEChanging(value);
                this._MTIME = value;
                this.OnMTIMEChanged();
                this.OnPropertyChanged("MTIME");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _MTIME;
        partial void OnMTIMEChanging(string value);
        partial void OnMTIMEChanged();
        /// <summary>
        /// There are no comments for Property MUSER in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string MUSER
        {
            get
            {
                return this._MUSER;
            }
            set
            {
                this.OnMUSERChanging(value);
                this._MUSER = value;
                this.OnMUSERChanged();
                this.OnPropertyChanged("MUSER");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _MUSER;
        partial void OnMUSERChanging(string value);
        partial void OnMUSERChanged();
        /// <summary>
        /// There are no comments for Property APCWEIGHT in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string APCWEIGHT
        {
            get
            {
                return this._APCWEIGHT;
            }
            set
            {
                this.OnAPCWEIGHTChanging(value);
                this._APCWEIGHT = value;
                this.OnAPCWEIGHTChanged();
                this.OnPropertyChanged("APCWEIGHT");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _APCWEIGHT;
        partial void OnAPCWEIGHTChanging(string value);
        partial void OnAPCWEIGHTChanged();
        /// <summary>
        /// There are no comments for Property IMPLANT in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IMPLANT
        {
            get
            {
                return this._IMPLANT;
            }
            set
            {
                this.OnIMPLANTChanging(value);
                this._IMPLANT = value;
                this.OnIMPLANTChanged();
                this.OnPropertyChanged("IMPLANT");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IMPLANT;
        partial void OnIMPLANTChanging(string value);
        partial void OnIMPLANTChanged();
        /// <summary>
        /// There are no comments for APCFEEObject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public APCFEE APCFEEObject
        {
            get
            {
                return this._APCFEEObject;
            }
            set
            {
                this._APCFEEObject = value;
                this.OnPropertyChanged("APCFEEObject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private APCFEE _APCFEEObject;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
