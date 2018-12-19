using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Sistrategia.SAT.CFDiWebSite.CFDI
{
    // <summary>
    // Elemento requerido para incorporar la información de la recepción de pagos.
    // </summary>
    public class ComprobantePago 
    {
        private Guid comprobantePagoId;
        //private Guid comprobanteId { get; set; }
        //private string version { get; set; }
        private DateTime fechaPago;
        private string formaDePagoP;
        private string monedaP;
        private string tipoCambioP;
        private decimal monto;
        private string numOperacion;
        private string rfcEmisorCtaOrd;
        private string nomBancoOrdExt;
        private string ctaOrdenante;
        private string rfcEmisorCtaBen;
        private string ctaBeneficiario;
        private string tipoCadPago;
        private string certPago;
        private string cadPago;
        private string selloPago;
        private int? ordinal;
        

        private List<ComprobantePagoDoctoRelacionado> doctosRelacionados { get; set; }

        public ComprobantePago()
        {
            this.doctosRelacionados = new List<ComprobantePagoDoctoRelacionado>();
        }

        public Guid ComprobantePagoId {
            get { return this.comprobantePagoId; }
            set { this.comprobantePagoId = value; }
        }

        //public Guid ComprobanteId {
        //    get { return this.comprobanteId; }
        //    set { this.comprobanteId = value; }
        //}

        //public string Version {
        //    get { return this.version; }
        //    set { this.version = value; }
        //}


        //FechaPago
        // <summary>
        // Atributo requerido para expresar la fecha y hora en la que el beneficiario recibe el pago. 
        // </summary>
        // <remarks>
        // Se expresa en la forma aaaa-mm-ddThh:mm:ss, de acuerdo con la especificación ISO 8601.
        // En caso de no contar con la hora se debe registrar 12:00:00.
        // </remarks>
        public DateTime FechaPago {
            get { return this.fechaPago; }
            set { this.fechaPago = value; }
        }
        // <xs:attribute name="FechaPago" use="required" type="tdCFDI:t_FechaH">
        //   <xs:annotation>
        //     <xs:documentation> 
        //       Atributo requerido para expresar la fecha y hora en la que el beneficiario recibe el pago. 
        //       Se expresa en la forma aaaa-mm-ddThh:mm:ss, de acuerdo con la especificación ISO 8601. En caso de no contar 
        //       con la hora se debe registrar 12:00:00.
        //     </xs:documentation>
        //   </xs:annotation>
        // </xs:attribute>
        //  ...
        // <xs:simpleType name="t_FechaH">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Tipo definido para la expresión de la fecha y hora. Se expresa en la forma AAAA-MM-DDThh:mm:ss
        //     </xs:documentation>
        //   </xs:annotation>
        //   <xs:restriction base="xs:dateTime">
        //     <xs:whiteSpace value="collapse"/>
        //     <xs:pattern value="(20[1-9][0-9])-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])T(([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9])"/>
        //   </xs:restriction>
        // </xs:simpleType>


        // FormaDePagoP
        // <summary>
        // Atributo requerido para expresar la clave de la forma en que se realiza el pago.
        // </summary>
        public string FormaDePagoP {
            get { return this.formaDePagoP; }
            set { this.formaDePagoP = value; }
        }
        // <xs:attribute name="FormaDePagoP" use="required" type="catCFDI:c_FormaPago">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Atributo requerido para expresar la clave de la forma en que se realiza el pago.
        //     </xs:documentation>
        //   </xs:annotation>
        // </xs:attribute>
        // ...
        // <xs:simpleType name="c_FormaPago">
        //   <xs:restriction base="xs:string">
        //     <xs:whiteSpace value="collapse"/>
        //     <xs:enumeration value="01"/>
        //     <xs:enumeration value="02"/>
        //     <xs:enumeration value="03"/>
        //     <xs:enumeration value="04"/>
        //     <xs:enumeration value="05"/>
        //     <xs:enumeration value="06"/>
        //     <xs:enumeration value="08"/>
        //     <xs:enumeration value="12"/>
        //     <xs:enumeration value="13"/>
        //     <xs:enumeration value="14"/>
        //     <xs:enumeration value="15"/>
        //     <xs:enumeration value="17"/>
        //     <xs:enumeration value="23"/>
        //     <xs:enumeration value="24"/>
        //     <xs:enumeration value="25"/>
        //     <xs:enumeration value="26"/>
        //     <xs:enumeration value="27"/>
        //     <xs:enumeration value="28"/>
        //     <xs:enumeration value="29"/>
        //     <xs:enumeration value="30"/>
        //     <xs:enumeration value="31"/>
        //     <xs:enumeration value="99"/>
        //   </xs:restriction>
        // </xs:simpleType>


        // MonedaP
        // <summary>
        // Atributo requerido para identificar la clave de la moneda utilizada para realizar el pago,
        // cuando se usa moneda nacional se registra MXN. El atributo Pagos:Pago:Monto y los atributos 
        // TotalImpuestosRetenidos, TotalImpuestosTrasladados, Traslados:Traslado:Importe y 
        // Retenciones:Retencion:Importe del nodo Pago:Impuestos deben ser expresados en esta moneda. 
        // Conforme con la especificación ISO 4217.
        // </summary>
        public string MonedaP {
            get { return this.monedaP; }
            set { this.monedaP = value; }
        }
        // <xs:attribute name="MonedaP" use="required" type="catCFDI:c_Moneda">
        // <xs:annotation>
        // <xs:documentation>
        //   Atributo requerido para identificar la clave de la moneda utilizada para realizar el pago, 
        //   cuando se usa moneda nacional se registra MXN. El atributo Pagos:Pago:Monto y los atributos 
        //   TotalImpuestosRetenidos, TotalImpuestosTrasladados, Traslados:Traslado:Importe y 
        //   Retenciones:Retencion:Importe del nodo Pago:Impuestos deben ser expresados en esta moneda. 
        //   Conforme con la especificación ISO 4217.
        // </xs:documentation>
        // </xs:annotation>
        // </xs:attribute>
        // ...
        // ...
        // <xs:simpleType name="c_Moneda">
        //   <xs:restriction base="xs:string">
        //     <xs:whiteSpace value="collapse"/>
        //     <xs:enumeration value="AED"/>
        //     <xs:enumeration value="AFN"/>
        //     ...
        //     <xs:enumeration value="MXN"/>
        //     ...
        //     <xs:enumeration value="USD"/>
        //     ...
        //     <xs:enumeration value="XXX"/>
        //     ...
        //     <xs:enumeration value="ZWL"/>
        //   </xs:restriction>
        // </xs:simpleType>


        // TipoCambioP
        // <summary>
        // Atributo condicional para expresar el tipo de cambio de la moneda a la fecha en que se realizó el pago. 
        //  El valor debe reflejar el número de pesos mexicanos que equivalen a una unidad de la divisa señalada en 
        //  el atributo MonedaP. 
        // </summary>
        // <remarks>
        // Es requerido cuando el atributo MonedaP es diferente a MXN.
        // </remarks>
        public string TipoCambioP {
            get { return this.tipoCambioP; }
            set { this.tipoCambioP = value; }
        }
        //<xs:attribute name="TipoCambioP" use="optional">
        //  <xs:annotation>
        //    <xs:documentation>
        //      Atributo condicional para expresar el tipo de cambio de la moneda a la fecha en que se realizó el pago. 
        //      El valor debe reflejar el número de pesos mexicanos que equivalen a una unidad de la divisa señalada en 
        //      el atributo MonedaP. Es requerido cuando el atributo MonedaP es diferente a MXN.
        //    </xs:documentation>
        //  </xs:annotation>
        //  <xs:simpleType>
        //    <xs:restriction base="xs:decimal">
        //      <xs:fractionDigits value="6"/>
        //      <xs:minInclusive value="0.000001"/>
        //      <xs:whiteSpace value="collapse"/>
        //    </xs:restriction>
        //  </xs:simpleType>
        //</xs:attribute>


        // Monto
        // <summary>
        // Atributo requerido para expresar el importe del pago.
        // </summary>
        // <remarks>
        // Requerido
        // </remarks>
        public decimal Monto {
            get { return this.monto; }
            set { this.monto = value; }
        }
        // <xs:attribute name="Monto" use="required" type="tdCFDI:t_Importe">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Atributo requerido para expresar el importe del pago.
        //     </xs:documentation>
        //   </xs:annotation>
        // </xs:attribute>
        // ...
        // <xs:simpleType name="t_Importe">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Tipo definido para expresar importes numéricos con fracción hasta seis decimales. No se permiten valores negativos.
        //     </xs:documentation>
        //   </xs:annotation>
        //   <xs:restriction base="xs:decimal">
        //     <xs:fractionDigits value="6"/>
        //     <xs:minInclusive value="0.000000"/>
        //     <xs:pattern value="[0-9]{1,18}(.[0-9]{1,6})?"/>
        //     <xs:whiteSpace value="collapse"/>
        //   </xs:restriction>
        // </xs:simpleType>


        // NumOperacion
        // <summary>
        // Atributo condicional para expresar el número de cheque, número de autorización, número de referencia, 
        //  clave de rastreo en caso de ser SPEI, línea de captura o algún número de referencia análogo que 
        //  identifique la operación que ampara el pago efectuado
        // </summary>
        public string NumOperacion {
            get { return this.numOperacion; }
            set { this.numOperacion = value; }
        }
        // <xs:attribute name="NumOperacion" use="optional">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Atributo condicional para expresar el número de cheque, número de autorización, número de referencia, 
        //       clave de rastreo en caso de ser SPEI, línea de captura o algún número de referencia análogo que 
        //       identifique la operación que ampara el pago efectuado
        //     </xs:documentation>
        //   </xs:annotation>
        //   <xs:simpleType>
        //     <xs:restriction base="xs:string">
        //       <xs:minLength value="1"/>
        //       <xs:maxLength value="100"/>
        //       <xs:pattern value="[^|]{1,100}"/>
        //     </xs:restriction>
        //   </xs:simpleType>
        // </xs:attribute>


        // RfcEmisorCtaOrd
        // <summary>
        //  Atributo condicional para expresar la clave RFC de la entidad emisora de la cuenta origen, 
        //   es decir, la operadora, el banco, la institución financiera, emisor de monedero electrónico, 
        //   etc., en caso de ser extranjero colocar XEXX010101000, considerar las reglas de obligatoriedad 
        //   publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        // </summary>
        public string RfcEmisorCtaOrd {
            get { return this.rfcEmisorCtaOrd; }
            set { this.rfcEmisorCtaOrd = value; }
        }
        // <xs:attribute name="RfcEmisorCtaOrd" use="optional">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Atributo condicional para expresar la clave RFC de la entidad emisora de la cuenta origen, 
        //       es decir, la operadora, el banco, la institución financiera, emisor de monedero electrónico, 
        //       etc., en caso de ser extranjero colocar XEXX010101000, considerar las reglas de obligatoriedad 
        //       publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        //     </xs:documentation>
        //   </xs:annotation>
        //   <xs:simpleType>
        //     <xs:restriction base="xs:string">
        //       <xs:minLength value="12"/>
        //       <xs:maxLength value="13"/>
        //       <xs:pattern value="XEXX010101000|[A-Z&Ñ]{3}[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[A-Z0-9]{2}[0-9A]"/>
        //       <xs:whiteSpace value="collapse"/>
        //     </xs:restriction>
        //   </xs:simpleType>
        // </xs:attribute>


        // NombBancoOrdExt
        // <summary>
        //   Atributo condicional para expresar el nombre del banco ordenante, es requerido en caso de ser extranjero. 
        //   Considerar las reglas de obligatoriedad publicadas en / la /página del SAT para éste atributo de acuerdo
        //   con el catálogo catCFDI:c_FormaPago.
        // </summary>
        public string NombBancoOrdExt {
            get { return this.nomBancoOrdExt; }
            set { this.nomBancoOrdExt = value; }
        }
        // <xs:attribute name="NomBancoOrdExt" use="optional">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Atributo condicional para expresar el nombre del banco ordenante, es requerido en caso de ser extranjero. 
        //       Considerar las reglas de obligatoriedad publicadas en / la /página del SAT para éste atributo de acuerdo
        //       con el catálogo catCFDI:c_FormaPago.
        //     </xs:documentation>
        //   </xs:annotation>
        //   <xs:simpleType>
        //     <xs:restriction base="xs:string">
        //       <xs:minLength value="1"/>
        //       <xs:maxLength value="300"/>
        //       <xs:whiteSpace value="collapse"/>
        //       <xs:pattern value="[^|]{1,300}"/>
        //     </xs:restriction>
        //   </xs:simpleType>
        // </xs:attribute>


        // CtaOrdenante
        // <summary>
        //  Atributo condicional para incorporar el número de la cuenta con la que se realizó el pago. 
        //  Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo 
        //  de acuerdo con el catálogo catCFDI:c_FormaPago
        // </summary>
        public string CtaOrdenante {
            get { return this.ctaOrdenante; }
            set { this.ctaOrdenante = value; }
        }
        // <xs:attribute name="CtaOrdenante" use="optional">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Atributo condicional para incorporar el número de la cuenta con la que se realizó el pago. 
        //       Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo 
        //       de acuerdo con el catálogo catCFDI:c_FormaPago
        //     </xs:documentation>
        //   </xs:annotation>
        //   <xs:simpleType>
        //     <xs:restriction base="xs:string">
        //       <xs:minLength value="10"/>
        //       <xs:maxLength value="50"/>
        //       <xs:whiteSpace value="collapse"/>
        //       <xs:pattern value="[A-Z0-9_]{10,50}"/>
        //     </xs:restriction>
        //   </xs:simpleType>
        // </xs:attribute>


        //RfcEmisorCtaBen
        // <summary>
        //  Atributo condicional para expresar la clave RFC de la entidad operadora de la cuenta destino, 
        //  es decir, la operadora, el banco, la institución financiera, emisor de monedero electrónico, etc.
        //  Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo 
        //  con el catálogo catCFDI:c_FormaPago.
        // </summary>
        public string RfcEmisorCtaBen {
            get { return this.rfcEmisorCtaBen; }
            set { this.rfcEmisorCtaBen = value; }
        }
        // <xs:attribute name="RfcEmisorCtaBen" use="optional" type="tdCFDI:t_RFC_PM">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Atributo condicional para expresar la clave RFC de la entidad operadora de la cuenta destino, 
        //       es decir, la operadora, el banco, la institución financiera, emisor de monedero electrónico, etc.
        //       Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo 
        //       con el catálogo catCFDI:c_FormaPago.
        //     </xs:documentation>
        //   </xs:annotation>
        // </xs:attribute>
        // ...
        // <xs:simpleType name="t_RFC_PM">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Tipo definido para la expresión de un Registro Federal de Contribuyentes de persona moral.
        //     </xs:documentation>
        //   </xs:annotation>
        //   <xs:restriction base="xs:string">
        //     <xs:whiteSpace value="collapse"/>
        //     <xs:minLength value="12"/>
        //     <xs:pattern value="[A-Z&Ñ]{3}[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[A-Z0-9]{2}[0-9A]"/>
        //   </xs:restriction>
        // </xs:simpleType>


        // CtaBeneficiario
        // <summary>
        //  Atributo condicional para incorporar el número de cuenta en donde se recibió el pago. 
        //  Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste 
        //  atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        // </summary>
        public string CtaBeneficiario {
            get { return this.ctaBeneficiario; }
            set { this.ctaBeneficiario = value; }
        }
        // <xs:attribute name="CtaBeneficiario" use="optional">
        // <xs:annotation>
        // <xs:documentation>
        // Atributo condicional para incorporar el número de cuenta en donde se recibió el pago. 
        // Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste 
        // atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        // </xs:documentation>
        // </xs:annotation>
        // <xs:simpleType>
        // <xs:restriction base="xs:string">
        // <xs:minLength value="10"/>
        // <xs:maxLength value="50"/>
        // <xs:whiteSpace value="collapse"/>
        // <xs:pattern value="[A-Z0-9_]{10,50}"/>
        // </xs:restriction>
        // </xs:simpleType>
        // </xs:attribute>
        

        // TipoCadPago
        // <summary>
        //   Atributo condicional para identificar la clave del tipo de cadena de pago que genera la entidad 
        //   receptora del pago. Considerar las reglas de obligatoriedad publicadas en la página del SAT para
        //   éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        // </summary>
        public string TipoCadPago {
            get { return this.tipoCadPago; }
            set { this.tipoCadPago = value; }
        }
        // <xs:attribute name="TipoCadPago" use="optional" type="catPagos:c_TipoCadenaPago">
        // <xs:annotation>
        // <xs:documentation>
        //   Atributo condicional para identificar la clave del tipo de cadena de pago que genera la entidad 
        //   receptora del pago. Considerar las reglas de obligatoriedad publicadas en la página del SAT para
        //   éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        // </xs:documentation>
        // </xs:annotation>
        // </xs:attribute>
        // ...
        // <xs:simpleType name="c_TipoCadenaPago">
        //  <xs:restriction base="xs:string">
        //    <xs:whiteSpace value="collapse"/>
        //    <xs:enumeration value="01"/>
        //  </xs:restriction>
        // </xs:simpleType>


        // CertPago
        // <summary>
        //    Atributo condicional que sirve para incorporar el certificado que ampara al pago, como una cadena de texto 
        //    en formato base 64. Es requerido en caso de que el atributo TipoCadPago contenga información.
        // </summary>
        public string CertPago {
            get { return this.certPago; }
            set { this.certPago = value; }
        }
        // <xs:attribute name="CertPago" use="optional">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Atributo condicional que sirve para incorporar el certificado que ampara al pago, como una cadena de texto 
        //       en formato base 64. Es requerido en caso de que el atributo TipoCadPago contenga información.
        //     </xs:documentation>
        //   </xs:annotation>
        // <xs:simpleType>
        // <xs:restriction base="xs:base64Binary">
        // <xs:whiteSpace value="collapse"/>
        // </xs:restriction>
        // </xs:simpleType>
        // </xs:attribute>


        // CadPago
        // <summary>
        //   Atributo condicional para expresar la cadena original del comprobante de pago generado por la entidad 
        //   emisora de la cuenta beneficiaria. Es requerido en caso de que el atributo TipoCadPago contenga información.
        // </summary>
        public string CadPago {
            get { return this.cadPago; }
            set { this.cadPago = value; }
        }
        // <xs:attribute name="CadPago" use="optional">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Atributo condicional para expresar la cadena original del comprobante de pago generado por la entidad 
        //       emisora de la cuenta beneficiaria. Es requerido en caso de que el atributo TipoCadPago contenga información.
        //     </xs:documentation>
        //   </xs:annotation>
        //   <xs:simpleType>
        //     <xs:restriction base="xs:string">
        //       <xs:minLength value="1"/>
        //       <xs:maxLength value="8192"/>
        //       <xs:whiteSpace value="collapse"/>
        //     </xs:restriction>
        //   </xs:simpleType>
        // </xs:attribute>


        // SelloPago
        // <summary>
        // Atributo condicional para integrar el sello digital que se asocie al pago. La entidad que emite el comprobante de pago,
        // ingresa una cadena original y el sello digital en una sección de dicho comprobante, este sello digital es el que se debe
        // registrar en este campo. Debe ser expresado como una cadena de texto en formato base 64. Es requerido en caso de que el 
        // atributo TipoCadPago contenga información.
        // </summary>
        public string SelloPago {
            get { return this.selloPago; }
            set { this.selloPago = value; }
        }
        // <xs:attribute name="SelloPago" use="optional">
        //   <xs:annotation>
        //     <xs:documentation>
        //       Atributo condicional para integrar el sello digital que se asocie al pago. La entidad que emite el comprobante de pago, 
        //       ingresa una cadena original y el sello digital en una sección de dicho comprobante, este sello digital es el que se debe 
        //       registrar en este campo. Debe ser expresado como una cadena de texto en formato base 64. Es requerido en caso de que el 
        //       atributo TipoCadPago contenga información.
        //     </xs:documentation>
        //   </xs:annotation>
        //   <xs:simpleType>
        //     <xs:restriction base="xs:base64Binary">
        //       <xs:whiteSpace value="collapse"/>
        //     </xs:restriction>
        //   </xs:simpleType>
        // </xs:attribute>


        [XmlIgnore]
        public int? Ordinal
        {
            get { return this.ordinal; }
            set { this.ordinal = value; }
        }

        public List<ComprobantePagoDoctoRelacionado> DoctosRelacionados {
            get { return this.doctosRelacionados; }
            set { this.doctosRelacionados = value; }
        }
    }
}