using System;

namespace xml_types
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class OFX
    {

        private OFXSIGNONMSGSRSV1 sIGNONMSGSRSV1Field;

        private OFXINVSTMTMSGSRSV1 iNVSTMTMSGSRSV1Field;

        private OFXSECLISTMSGSRSV1 sECLISTMSGSRSV1Field;

        /// <remarks/>
        public OFXSIGNONMSGSRSV1 SIGNONMSGSRSV1
        {
            get
            {
                return this.sIGNONMSGSRSV1Field;
            }
            set
            {
                this.sIGNONMSGSRSV1Field = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1 INVSTMTMSGSRSV1
        {
            get
            {
                return this.iNVSTMTMSGSRSV1Field;
            }
            set
            {
                this.iNVSTMTMSGSRSV1Field = value;
            }
        }

        /// <remarks/>
        public OFXSECLISTMSGSRSV1 SECLISTMSGSRSV1
        {
            get
            {
                return this.sECLISTMSGSRSV1Field;
            }
            set
            {
                this.sECLISTMSGSRSV1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSIGNONMSGSRSV1
    {

        private OFXSIGNONMSGSRSV1SONRS sONRSField;

        /// <remarks/>
        public OFXSIGNONMSGSRSV1SONRS SONRS
        {
            get
            {
                return this.sONRSField;
            }
            set
            {
                this.sONRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSIGNONMSGSRSV1SONRS
    {

        private OFXSIGNONMSGSRSV1SONRSSTATUS sTATUSField;

        private decimal dTSERVERField;

        private string lANGUAGEField;

        private OFXSIGNONMSGSRSV1SONRSFI fiField;

        private ushort iNTUBIDField;

        private ulong iNTUUSERIDField;

        /// <remarks/>
        public OFXSIGNONMSGSRSV1SONRSSTATUS STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }

        /// <remarks/>
        public decimal DTSERVER
        {
            get
            {
                return this.dTSERVERField;
            }
            set
            {
                this.dTSERVERField = value;
            }
        }

        /// <remarks/>
        public string LANGUAGE
        {
            get
            {
                return this.lANGUAGEField;
            }
            set
            {
                this.lANGUAGEField = value;
            }
        }

        /// <remarks/>
        public OFXSIGNONMSGSRSV1SONRSFI FI
        {
            get
            {
                return this.fiField;
            }
            set
            {
                this.fiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INTU.BID")]
        public ushort INTUBID
        {
            get
            {
                return this.iNTUBIDField;
            }
            set
            {
                this.iNTUBIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INTU.USERID")]
        public ulong INTUUSERID
        {
            get
            {
                return this.iNTUUSERIDField;
            }
            set
            {
                this.iNTUUSERIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSIGNONMSGSRSV1SONRSSTATUS
    {

        private byte cODEField;

        private string sEVERITYField;

        private string mESSAGEField;

        /// <remarks/>
        public byte CODE
        {
            get
            {
                return this.cODEField;
            }
            set
            {
                this.cODEField = value;
            }
        }

        /// <remarks/>
        public string SEVERITY
        {
            get
            {
                return this.sEVERITYField;
            }
            set
            {
                this.sEVERITYField = value;
            }
        }

        /// <remarks/>
        public string MESSAGE
        {
            get
            {
                return this.mESSAGEField;
            }
            set
            {
                this.mESSAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSIGNONMSGSRSV1SONRSFI
    {

        private ushort oRGField;

        private ushort fIDField;

        /// <remarks/>
        public ushort ORG
        {
            get
            {
                return this.oRGField;
            }
            set
            {
                this.oRGField = value;
            }
        }

        /// <remarks/>
        public ushort FID
        {
            get
            {
                return this.fIDField;
            }
            set
            {
                this.fIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRS iNVSTMTTRNRSField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRS INVSTMTTRNRS
        {
            get
            {
                return this.iNVSTMTTRNRSField;
            }
            set
            {
                this.iNVSTMTTRNRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRS
    {

        private byte tRNUIDField;

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSSTATUS sTATUSField;

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRS iNVSTMTRSField;

        /// <remarks/>
        public byte TRNUID
        {
            get
            {
                return this.tRNUIDField;
            }
            set
            {
                this.tRNUIDField = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSSTATUS STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRS INVSTMTRS
        {
            get
            {
                return this.iNVSTMTRSField;
            }
            set
            {
                this.iNVSTMTRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSSTATUS
    {

        private byte cODEField;

        private string sEVERITYField;

        private string mESSAGEField;

        /// <remarks/>
        public byte CODE
        {
            get
            {
                return this.cODEField;
            }
            set
            {
                this.cODEField = value;
            }
        }

        /// <remarks/>
        public string SEVERITY
        {
            get
            {
                return this.sEVERITYField;
            }
            set
            {
                this.sEVERITYField = value;
            }
        }

        /// <remarks/>
        public string MESSAGE
        {
            get
            {
                return this.mESSAGEField;
            }
            set
            {
                this.mESSAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRS
    {

        private decimal dTASOFField;

        private string cURDEFField;

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVACCTFROM iNVACCTFROMField;

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLIST iNVTRANLISTField;

        private object iNVPOSLISTField;

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVBAL iNVBALField;

        /// <remarks/>
        public decimal DTASOF
        {
            get
            {
                return this.dTASOFField;
            }
            set
            {
                this.dTASOFField = value;
            }
        }

        /// <remarks/>
        public string CURDEF
        {
            get
            {
                return this.cURDEFField;
            }
            set
            {
                this.cURDEFField = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVACCTFROM INVACCTFROM
        {
            get
            {
                return this.iNVACCTFROMField;
            }
            set
            {
                this.iNVACCTFROMField = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLIST INVTRANLIST
        {
            get
            {
                return this.iNVTRANLISTField;
            }
            set
            {
                this.iNVTRANLISTField = value;
            }
        }

        /// <remarks/>
        public object INVPOSLIST
        {
            get
            {
                return this.iNVPOSLISTField;
            }
            set
            {
                this.iNVPOSLISTField = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVBAL INVBAL
        {
            get
            {
                return this.iNVBALField;
            }
            set
            {
                this.iNVBALField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVACCTFROM
    {

        private ushort bROKERIDField;

        private string aCCTIDField;

        /// <remarks/>
        public ushort BROKERID
        {
            get
            {
                return this.bROKERIDField;
            }
            set
            {
                this.bROKERIDField = value;
            }
        }

        /// <remarks/>
        public string ACCTID
        {
            get
            {
                return this.aCCTIDField;
            }
            set
            {
                this.aCCTIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLIST
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BUYMF", typeof(BuyMutualFund))]
        [System.Xml.Serialization.XmlElementAttribute("BUYSTOCK", typeof(BuyStock))]
        [System.Xml.Serialization.XmlElementAttribute("DTEND", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("DTSTART", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("INCOME", typeof(Income))]
        [System.Xml.Serialization.XmlElementAttribute("INVBANKTRAN", typeof(BankTransaction))]
        [System.Xml.Serialization.XmlElementAttribute("SELLMF", typeof(SellMutualFund))]
        [System.Xml.Serialization.XmlElementAttribute("SELLSTOCK", typeof(SellStock))]
        [System.Xml.Serialization.XmlElementAttribute("TRANSFER", typeof(Transfer))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BuyMutualFund
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYMFINVBUY iNVBUYField;

        private string bUYTYPEField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYMFINVBUY INVBUY
        {
            get
            {
                return this.iNVBUYField;
            }
            set
            {
                this.iNVBUYField = value;
            }
        }

        /// <remarks/>
        public string BUYTYPE
        {
            get
            {
                return this.bUYTYPEField;
            }
            set
            {
                this.bUYTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYMFINVBUY
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYMFINVBUYINVTRAN iNVTRANField;

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYMFINVBUYSECID sECIDField;

        private decimal uNITSField;

        private decimal uNITPRICEField;

        private decimal tOTALField;

        private string sUBACCTSECField;

        private string sUBACCTFUNDField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYMFINVBUYINVTRAN INVTRAN
        {
            get
            {
                return this.iNVTRANField;
            }
            set
            {
                this.iNVTRANField = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYMFINVBUYSECID SECID
        {
            get
            {
                return this.sECIDField;
            }
            set
            {
                this.sECIDField = value;
            }
        }

        /// <remarks/>
        public decimal UNITS
        {
            get
            {
                return this.uNITSField;
            }
            set
            {
                this.uNITSField = value;
            }
        }

        /// <remarks/>
        public decimal UNITPRICE
        {
            get
            {
                return this.uNITPRICEField;
            }
            set
            {
                this.uNITPRICEField = value;
            }
        }

        /// <remarks/>
        public decimal TOTAL
        {
            get
            {
                return this.tOTALField;
            }
            set
            {
                this.tOTALField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTSEC
        {
            get
            {
                return this.sUBACCTSECField;
            }
            set
            {
                this.sUBACCTSECField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTFUND
        {
            get
            {
                return this.sUBACCTFUNDField;
            }
            set
            {
                this.sUBACCTFUNDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYMFINVBUYINVTRAN
    {

        private decimal fITIDField;

        private decimal dTTRADEField;

        private decimal dTSETTLEField;

        /// <remarks/>
        public decimal FITID
        {
            get
            {
                return this.fITIDField;
            }
            set
            {
                this.fITIDField = value;
            }
        }

        /// <remarks/>
        public decimal DTTRADE
        {
            get
            {
                return this.dTTRADEField;
            }
            set
            {
                this.dTTRADEField = value;
            }
        }

        /// <remarks/>
        public decimal DTSETTLE
        {
            get
            {
                return this.dTSETTLEField;
            }
            set
            {
                this.dTSETTLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYMFINVBUYSECID
    {

        private string uNIQUEIDField;

        private string uNIQUEIDTYPEField;

        /// <remarks/>
        public string UNIQUEID
        {
            get
            {
                return this.uNIQUEIDField;
            }
            set
            {
                this.uNIQUEIDField = value;
            }
        }

        /// <remarks/>
        public string UNIQUEIDTYPE
        {
            get
            {
                return this.uNIQUEIDTYPEField;
            }
            set
            {
                this.uNIQUEIDTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BuyStock
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYSTOCKINVBUY iNVBUYField;

        private string bUYTYPEField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYSTOCKINVBUY INVBUY
        {
            get
            {
                return this.iNVBUYField;
            }
            set
            {
                this.iNVBUYField = value;
            }
        }

        /// <remarks/>
        public string BUYTYPE
        {
            get
            {
                return this.bUYTYPEField;
            }
            set
            {
                this.bUYTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYSTOCKINVBUY
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYSTOCKINVBUYINVTRAN iNVTRANField;

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYSTOCKINVBUYSECID sECIDField;

        private decimal uNITSField;

        private decimal uNITPRICEField;

        private decimal tOTALField;

        private string sUBACCTSECField;

        private string sUBACCTFUNDField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYSTOCKINVBUYINVTRAN INVTRAN
        {
            get
            {
                return this.iNVTRANField;
            }
            set
            {
                this.iNVTRANField = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYSTOCKINVBUYSECID SECID
        {
            get
            {
                return this.sECIDField;
            }
            set
            {
                this.sECIDField = value;
            }
        }

        /// <remarks/>
        public decimal UNITS
        {
            get
            {
                return this.uNITSField;
            }
            set
            {
                this.uNITSField = value;
            }
        }

        /// <remarks/>
        public decimal UNITPRICE
        {
            get
            {
                return this.uNITPRICEField;
            }
            set
            {
                this.uNITPRICEField = value;
            }
        }

        /// <remarks/>
        public decimal TOTAL
        {
            get
            {
                return this.tOTALField;
            }
            set
            {
                this.tOTALField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTSEC
        {
            get
            {
                return this.sUBACCTSECField;
            }
            set
            {
                this.sUBACCTSECField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTFUND
        {
            get
            {
                return this.sUBACCTFUNDField;
            }
            set
            {
                this.sUBACCTFUNDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYSTOCKINVBUYINVTRAN
    {

        private decimal fITIDField;

        private decimal dTTRADEField;

        private decimal dTSETTLEField;

        /// <remarks/>
        public decimal FITID
        {
            get
            {
                return this.fITIDField;
            }
            set
            {
                this.fITIDField = value;
            }
        }

        /// <remarks/>
        public decimal DTTRADE
        {
            get
            {
                return this.dTTRADEField;
            }
            set
            {
                this.dTTRADEField = value;
            }
        }

        /// <remarks/>
        public decimal DTSETTLE
        {
            get
            {
                return this.dTSETTLEField;
            }
            set
            {
                this.dTSETTLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTBUYSTOCKINVBUYSECID
    {

        private string uNIQUEIDField;

        private string uNIQUEIDTYPEField;

        /// <remarks/>
        public string UNIQUEID
        {
            get
            {
                return this.uNIQUEIDField;
            }
            set
            {
                this.uNIQUEIDField = value;
            }
        }

        /// <remarks/>
        public string UNIQUEIDTYPE
        {
            get
            {
                return this.uNIQUEIDTYPEField;
            }
            set
            {
                this.uNIQUEIDTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Income
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTINCOMEINVTRAN iNVTRANField;

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTINCOMESECID sECIDField;

        private string iNCOMETYPEField;

        private decimal tOTALField;

        private string sUBACCTSECField;

        private string sUBACCTFUNDField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTINCOMEINVTRAN INVTRAN
        {
            get
            {
                return this.iNVTRANField;
            }
            set
            {
                this.iNVTRANField = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTINCOMESECID SECID
        {
            get
            {
                return this.sECIDField;
            }
            set
            {
                this.sECIDField = value;
            }
        }

        /// <remarks/>
        public string INCOMETYPE
        {
            get
            {
                return this.iNCOMETYPEField;
            }
            set
            {
                this.iNCOMETYPEField = value;
            }
        }

        /// <remarks/>
        public decimal TOTAL
        {
            get
            {
                return this.tOTALField;
            }
            set
            {
                this.tOTALField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTSEC
        {
            get
            {
                return this.sUBACCTSECField;
            }
            set
            {
                this.sUBACCTSECField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTFUND
        {
            get
            {
                return this.sUBACCTFUNDField;
            }
            set
            {
                this.sUBACCTFUNDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTINCOMEINVTRAN
    {

        private decimal fITIDField;

        private decimal dTTRADEField;

        private decimal dTSETTLEField;

        /// <remarks/>
        public decimal FITID
        {
            get
            {
                return this.fITIDField;
            }
            set
            {
                this.fITIDField = value;
            }
        }

        /// <remarks/>
        public decimal DTTRADE
        {
            get
            {
                return this.dTTRADEField;
            }
            set
            {
                this.dTTRADEField = value;
            }
        }

        /// <remarks/>
        public decimal DTSETTLE
        {
            get
            {
                return this.dTSETTLEField;
            }
            set
            {
                this.dTSETTLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTINCOMESECID
    {

        private string uNIQUEIDField;

        private string uNIQUEIDTYPEField;

        /// <remarks/>
        public string UNIQUEID
        {
            get
            {
                return this.uNIQUEIDField;
            }
            set
            {
                this.uNIQUEIDField = value;
            }
        }

        /// <remarks/>
        public string UNIQUEIDTYPE
        {
            get
            {
                return this.uNIQUEIDTYPEField;
            }
            set
            {
                this.uNIQUEIDTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BankTransaction
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTINVBANKTRANSTMTTRN sTMTTRNField;

        private string sUBACCTFUNDField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTINVBANKTRANSTMTTRN STMTTRN
        {
            get
            {
                return this.sTMTTRNField;
            }
            set
            {
                this.sTMTTRNField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTFUND
        {
            get
            {
                return this.sUBACCTFUNDField;
            }
            set
            {
                this.sUBACCTFUNDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTINVBANKTRANSTMTTRN
    {

        private string tRNTYPEField;

        private decimal dTPOSTEDField;

        private decimal tRNAMTField;

        private decimal fITIDField;

        /// <remarks/>
        public string TRNTYPE
        {
            get
            {
                return this.tRNTYPEField;
            }
            set
            {
                this.tRNTYPEField = value;
            }
        }

        /// <remarks/>
        public decimal DTPOSTED
        {
            get
            {
                return this.dTPOSTEDField;
            }
            set
            {
                this.dTPOSTEDField = value;
            }
        }

        /// <remarks/>
        public decimal TRNAMT
        {
            get
            {
                return this.tRNAMTField;
            }
            set
            {
                this.tRNAMTField = value;
            }
        }

        /// <remarks/>
        public decimal FITID
        {
            get
            {
                return this.fITIDField;
            }
            set
            {
                this.fITIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SellMutualFund
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLMFINVSELL iNVSELLField;

        private string sELLTYPEField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLMFINVSELL INVSELL
        {
            get
            {
                return this.iNVSELLField;
            }
            set
            {
                this.iNVSELLField = value;
            }
        }

        /// <remarks/>
        public string SELLTYPE
        {
            get
            {
                return this.sELLTYPEField;
            }
            set
            {
                this.sELLTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLMFINVSELL
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLMFINVSELLINVTRAN iNVTRANField;

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLMFINVSELLSECID sECIDField;

        private decimal uNITSField;

        private decimal uNITPRICEField;

        private decimal tOTALField;

        private string sUBACCTSECField;

        private string sUBACCTFUNDField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLMFINVSELLINVTRAN INVTRAN
        {
            get
            {
                return this.iNVTRANField;
            }
            set
            {
                this.iNVTRANField = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLMFINVSELLSECID SECID
        {
            get
            {
                return this.sECIDField;
            }
            set
            {
                this.sECIDField = value;
            }
        }

        /// <remarks/>
        public decimal UNITS
        {
            get
            {
                return this.uNITSField;
            }
            set
            {
                this.uNITSField = value;
            }
        }

        /// <remarks/>
        public decimal UNITPRICE
        {
            get
            {
                return this.uNITPRICEField;
            }
            set
            {
                this.uNITPRICEField = value;
            }
        }

        /// <remarks/>
        public decimal TOTAL
        {
            get
            {
                return this.tOTALField;
            }
            set
            {
                this.tOTALField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTSEC
        {
            get
            {
                return this.sUBACCTSECField;
            }
            set
            {
                this.sUBACCTSECField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTFUND
        {
            get
            {
                return this.sUBACCTFUNDField;
            }
            set
            {
                this.sUBACCTFUNDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLMFINVSELLINVTRAN
    {

        private decimal fITIDField;

        private decimal dTTRADEField;

        private decimal dTSETTLEField;

        /// <remarks/>
        public decimal FITID
        {
            get
            {
                return this.fITIDField;
            }
            set
            {
                this.fITIDField = value;
            }
        }

        /// <remarks/>
        public decimal DTTRADE
        {
            get
            {
                return this.dTTRADEField;
            }
            set
            {
                this.dTTRADEField = value;
            }
        }

        /// <remarks/>
        public decimal DTSETTLE
        {
            get
            {
                return this.dTSETTLEField;
            }
            set
            {
                this.dTSETTLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLMFINVSELLSECID
    {

        private string uNIQUEIDField;

        private string uNIQUEIDTYPEField;

        /// <remarks/>
        public string UNIQUEID
        {
            get
            {
                return this.uNIQUEIDField;
            }
            set
            {
                this.uNIQUEIDField = value;
            }
        }

        /// <remarks/>
        public string UNIQUEIDTYPE
        {
            get
            {
                return this.uNIQUEIDTYPEField;
            }
            set
            {
                this.uNIQUEIDTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SellStock
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLSTOCKINVSELL iNVSELLField;

        private string sELLTYPEField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLSTOCKINVSELL INVSELL
        {
            get
            {
                return this.iNVSELLField;
            }
            set
            {
                this.iNVSELLField = value;
            }
        }

        /// <remarks/>
        public string SELLTYPE
        {
            get
            {
                return this.sELLTYPEField;
            }
            set
            {
                this.sELLTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLSTOCKINVSELL
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLSTOCKINVSELLINVTRAN iNVTRANField;

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLSTOCKINVSELLSECID sECIDField;

        private decimal uNITSField;

        private decimal uNITPRICEField;

        private decimal tOTALField;

        private string sUBACCTSECField;

        private string sUBACCTFUNDField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLSTOCKINVSELLINVTRAN INVTRAN
        {
            get
            {
                return this.iNVTRANField;
            }
            set
            {
                this.iNVTRANField = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLSTOCKINVSELLSECID SECID
        {
            get
            {
                return this.sECIDField;
            }
            set
            {
                this.sECIDField = value;
            }
        }

        /// <remarks/>
        public decimal UNITS
        {
            get
            {
                return this.uNITSField;
            }
            set
            {
                this.uNITSField = value;
            }
        }

        /// <remarks/>
        public decimal UNITPRICE
        {
            get
            {
                return this.uNITPRICEField;
            }
            set
            {
                this.uNITPRICEField = value;
            }
        }

        /// <remarks/>
        public decimal TOTAL
        {
            get
            {
                return this.tOTALField;
            }
            set
            {
                this.tOTALField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTSEC
        {
            get
            {
                return this.sUBACCTSECField;
            }
            set
            {
                this.sUBACCTSECField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTFUND
        {
            get
            {
                return this.sUBACCTFUNDField;
            }
            set
            {
                this.sUBACCTFUNDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLSTOCKINVSELLINVTRAN
    {

        private decimal fITIDField;

        private decimal dTTRADEField;

        private decimal dTSETTLEField;

        /// <remarks/>
        public decimal FITID
        {
            get
            {
                return this.fITIDField;
            }
            set
            {
                this.fITIDField = value;
            }
        }

        /// <remarks/>
        public decimal DTTRADE
        {
            get
            {
                return this.dTTRADEField;
            }
            set
            {
                this.dTTRADEField = value;
            }
        }

        /// <remarks/>
        public decimal DTSETTLE
        {
            get
            {
                return this.dTSETTLEField;
            }
            set
            {
                this.dTSETTLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTSELLSTOCKINVSELLSECID
    {

        private string uNIQUEIDField;

        private string uNIQUEIDTYPEField;

        /// <remarks/>
        public string UNIQUEID
        {
            get
            {
                return this.uNIQUEIDField;
            }
            set
            {
                this.uNIQUEIDField = value;
            }
        }

        /// <remarks/>
        public string UNIQUEIDTYPE
        {
            get
            {
                return this.uNIQUEIDTYPEField;
            }
            set
            {
                this.uNIQUEIDTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Transfer
    {

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTTRANSFERINVTRAN iNVTRANField;

        private OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTTRANSFERSECID sECIDField;

        private string sUBACCTSECField;

        private decimal uNITSField;

        private string tFERACTIONField;

        private string pOSTYPEField;

        private decimal aVGCOSTBASISField;

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTTRANSFERINVTRAN INVTRAN
        {
            get
            {
                return this.iNVTRANField;
            }
            set
            {
                this.iNVTRANField = value;
            }
        }

        /// <remarks/>
        public OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTTRANSFERSECID SECID
        {
            get
            {
                return this.sECIDField;
            }
            set
            {
                this.sECIDField = value;
            }
        }

        /// <remarks/>
        public string SUBACCTSEC
        {
            get
            {
                return this.sUBACCTSECField;
            }
            set
            {
                this.sUBACCTSECField = value;
            }
        }

        /// <remarks/>
        public decimal UNITS
        {
            get
            {
                return this.uNITSField;
            }
            set
            {
                this.uNITSField = value;
            }
        }

        /// <remarks/>
        public string TFERACTION
        {
            get
            {
                return this.tFERACTIONField;
            }
            set
            {
                this.tFERACTIONField = value;
            }
        }

        /// <remarks/>
        public string POSTYPE
        {
            get
            {
                return this.pOSTYPEField;
            }
            set
            {
                this.pOSTYPEField = value;
            }
        }

        /// <remarks/>
        public decimal AVGCOSTBASIS
        {
            get
            {
                return this.aVGCOSTBASISField;
            }
            set
            {
                this.aVGCOSTBASISField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTTRANSFERINVTRAN
    {

        private decimal fITIDField;

        private decimal dTTRADEField;

        private decimal dTSETTLEField;

        /// <remarks/>
        public decimal FITID
        {
            get
            {
                return this.fITIDField;
            }
            set
            {
                this.fITIDField = value;
            }
        }

        /// <remarks/>
        public decimal DTTRADE
        {
            get
            {
                return this.dTTRADEField;
            }
            set
            {
                this.dTTRADEField = value;
            }
        }

        /// <remarks/>
        public decimal DTSETTLE
        {
            get
            {
                return this.dTSETTLEField;
            }
            set
            {
                this.dTSETTLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVTRANLISTTRANSFERSECID
    {

        private string uNIQUEIDField;

        private string uNIQUEIDTYPEField;

        /// <remarks/>
        public string UNIQUEID
        {
            get
            {
                return this.uNIQUEIDField;
            }
            set
            {
                this.uNIQUEIDField = value;
            }
        }

        /// <remarks/>
        public string UNIQUEIDTYPE
        {
            get
            {
                return this.uNIQUEIDTYPEField;
            }
            set
            {
                this.uNIQUEIDTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        BUYMF,

        /// <remarks/>
        BUYSTOCK,

        /// <remarks/>
        DTEND,

        /// <remarks/>
        DTSTART,

        /// <remarks/>
        INCOME,

        /// <remarks/>
        INVBANKTRAN,

        /// <remarks/>
        SELLMF,

        /// <remarks/>
        SELLSTOCK,

        /// <remarks/>
        TRANSFER,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXINVSTMTMSGSRSV1INVSTMTTRNRSINVSTMTRSINVBAL
    {

        private decimal aVAILCASHField;

        private decimal mARGINBALANCEField;

        private decimal sHORTBALANCEField;

        /// <remarks/>
        public decimal AVAILCASH
        {
            get
            {
                return this.aVAILCASHField;
            }
            set
            {
                this.aVAILCASHField = value;
            }
        }

        /// <remarks/>
        public decimal MARGINBALANCE
        {
            get
            {
                return this.mARGINBALANCEField;
            }
            set
            {
                this.mARGINBALANCEField = value;
            }
        }

        /// <remarks/>
        public decimal SHORTBALANCE
        {
            get
            {
                return this.sHORTBALANCEField;
            }
            set
            {
                this.sHORTBALANCEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSECLISTMSGSRSV1
    {

        private OFXSECLISTMSGSRSV1SECLIST sECLISTField;

        /// <remarks/>
        public OFXSECLISTMSGSRSV1SECLIST SECLIST
        {
            get
            {
                return this.sECLISTField;
            }
            set
            {
                this.sECLISTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSECLISTMSGSRSV1SECLIST
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MFINFO", typeof(OFXSECLISTMSGSRSV1SECLISTMFINFO))]
        [System.Xml.Serialization.XmlElementAttribute("STOCKINFO", typeof(OFXSECLISTMSGSRSV1SECLISTSTOCKINFO))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSECLISTMSGSRSV1SECLISTMFINFO
    {

        private OFXSECLISTMSGSRSV1SECLISTMFINFOSECINFO sECINFOField;

        /// <remarks/>
        public OFXSECLISTMSGSRSV1SECLISTMFINFOSECINFO SECINFO
        {
            get
            {
                return this.sECINFOField;
            }
            set
            {
                this.sECINFOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSECLISTMSGSRSV1SECLISTMFINFOSECINFO
    {

        private OFXSECLISTMSGSRSV1SECLISTMFINFOSECINFOSECID sECIDField;

        private string sECNAMEField;

        private string tICKERField;

        /// <remarks/>
        public OFXSECLISTMSGSRSV1SECLISTMFINFOSECINFOSECID SECID
        {
            get
            {
                return this.sECIDField;
            }
            set
            {
                this.sECIDField = value;
            }
        }

        /// <remarks/>
        public string SECNAME
        {
            get
            {
                return this.sECNAMEField;
            }
            set
            {
                this.sECNAMEField = value;
            }
        }

        /// <remarks/>
        public string TICKER
        {
            get
            {
                return this.tICKERField;
            }
            set
            {
                this.tICKERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSECLISTMSGSRSV1SECLISTMFINFOSECINFOSECID
    {

        private string uNIQUEIDField;

        private string uNIQUEIDTYPEField;

        /// <remarks/>
        public string UNIQUEID
        {
            get
            {
                return this.uNIQUEIDField;
            }
            set
            {
                this.uNIQUEIDField = value;
            }
        }

        /// <remarks/>
        public string UNIQUEIDTYPE
        {
            get
            {
                return this.uNIQUEIDTYPEField;
            }
            set
            {
                this.uNIQUEIDTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSECLISTMSGSRSV1SECLISTSTOCKINFO
    {

        private OFXSECLISTMSGSRSV1SECLISTSTOCKINFOSECINFO sECINFOField;

        /// <remarks/>
        public OFXSECLISTMSGSRSV1SECLISTSTOCKINFOSECINFO SECINFO
        {
            get
            {
                return this.sECINFOField;
            }
            set
            {
                this.sECINFOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSECLISTMSGSRSV1SECLISTSTOCKINFOSECINFO
    {

        private OFXSECLISTMSGSRSV1SECLISTSTOCKINFOSECINFOSECID sECIDField;

        private string sECNAMEField;

        private string tICKERField;

        /// <remarks/>
        public OFXSECLISTMSGSRSV1SECLISTSTOCKINFOSECINFOSECID SECID
        {
            get
            {
                return this.sECIDField;
            }
            set
            {
                this.sECIDField = value;
            }
        }

        /// <remarks/>
        public string SECNAME
        {
            get
            {
                return this.sECNAMEField;
            }
            set
            {
                this.sECNAMEField = value;
            }
        }

        /// <remarks/>
        public string TICKER
        {
            get
            {
                return this.tICKERField;
            }
            set
            {
                this.tICKERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OFXSECLISTMSGSRSV1SECLISTSTOCKINFOSECINFOSECID
    {

        private string uNIQUEIDField;

        private string uNIQUEIDTYPEField;

        /// <remarks/>
        public string UNIQUEID
        {
            get
            {
                return this.uNIQUEIDField;
            }
            set
            {
                this.uNIQUEIDField = value;
            }
        }

        /// <remarks/>
        public string UNIQUEIDTYPE
        {
            get
            {
                return this.uNIQUEIDTYPEField;
            }
            set
            {
                this.uNIQUEIDTYPEField = value;
            }
        }
    }

}
