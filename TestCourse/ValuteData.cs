﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestCourse
{
    // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1", IsNullable = false)]
    public partial class diffgram
    {

        private ValuteDataValuteCursOnDate[] valuteDataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "")]
        [System.Xml.Serialization.XmlArrayItemAttribute("ValuteCursOnDate", IsNullable = false)]
        public ValuteDataValuteCursOnDate[] ValuteData
        {
            get
            {
                return this.valuteDataField;
            }
            set
            {
                this.valuteDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ValuteDataValuteCursOnDate
    {

        private string vnameField;

        private ushort vnomField;

        private decimal vcursField;

        private ushort vcodeField;

        private string vchCodeField;

        private string idField;

        private byte rowOrderField;

        /// <remarks/>
        public string Vname
        {
            get
            {
                return this.vnameField;
            }
            set
            {
                this.vnameField = value;
            }
        }

        /// <remarks/>
        public ushort Vnom
        {
            get
            {
                return this.vnomField;
            }
            set
            {
                this.vnomField = value;
            }
        }

        /// <remarks/>
        public decimal Vcurs
        {
            get
            {
                return this.vcursField;
            }
            set
            {
                this.vcursField = value;
            }
        }

        /// <remarks/>
        public ushort Vcode
        {
            get
            {
                return this.vcodeField;
            }
            set
            {
                this.vcodeField = value;
            }
        }

        /// <remarks/>
        public string VchCode
        {
            get
            {
                return this.vchCodeField;
            }
            set
            {
                this.vchCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:xml-msdata")]
        public byte rowOrder
        {
            get
            {
                return this.rowOrderField;
            }
            set
            {
                this.rowOrderField = value;
            }
        }
    }

    public partial class ValuteData
    {

        private ValuteDataValuteCursOnDate[] valuteCursOnDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValuteCursOnDate")]
        public ValuteDataValuteCursOnDate[] ValuteCursOnDate
        {
            get
            {
                return this.valuteCursOnDateField;
            }
            set
            {
                this.valuteCursOnDateField = value;
            }
        }
    }

}
