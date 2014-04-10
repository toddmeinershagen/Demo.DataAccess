namespace Demo.DataAccess.Core.Models
{
    public class APCFEED
    {
        public string SYSKEY { get; set; }
        public string APC { get; set; }
        public string APC_DP { get; set; }
        public string PMT_RATE { get; set; }
        public string NAT_COINS { get; set; }
        public string MIN_COINS { get; set; }
        public string PAY_OUTLR { get; set; }
        public string CO_PCNT { get; set; }
        public string EFF_DATE { get; set; }
        public string APCFEE { get; set; }
        public string MDATE { get; set; }
        public string MTIME { get; set; }
        public string MUSER { get; set; }
        public string APCWEIGHT { get; set; }
        public string IMPLANT { get; set; }

        public virtual APCFEE APCFEEObject { get; set; }
    }
}
