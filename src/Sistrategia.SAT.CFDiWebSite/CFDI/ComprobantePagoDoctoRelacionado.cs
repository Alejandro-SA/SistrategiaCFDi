using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistrategia.SAT.CFDiWebSite.CFDI
{
    public class ComprobantePagoDoctoRelacionado
    {

        private Guid comprobantePagoDoctoRelacionadoId { get; set; }
        //private Guid comprobantePagoId { get; set; }
        //private Guid doctoRelacionadoId { get; set; }
        private string idDocumento { get; set; }
        private string serie { get; set; }
        private string folio { get; set; }
        private string monedaDR { get; set; }
        private decimal tipoCambioDR { get; set; }
        private string metodoDePagoDR { get; set; }
        private int numParcialidades { get; set; }
        private decimal impSaldAnt { get; set; }
        private decimal impPagado { get; set; }
        private decimal impSaldoInsoluto { get; set; }
        private int ordinal { get; set; }

        public Guid ComprobantePagoDoctoRelacionadoId {
            get { return this.comprobantePagoDoctoRelacionadoId; }
            set { this.comprobantePagoDoctoRelacionadoId = value; }
        }

        //public Guid ComprobantePagoId {
        //    get { return this.comprobantePagoId; }
        //    set { this.comprobantePagoId = value; }
        //}

        //public Guid DoctoRelacionadoId {
        //    get { return this.doctoRelacionadoId; }
        //    set { this.doctoRelacionadoId = value; }
        //}


        // IdDocumento
        // <summary>
        // Atributo requerido para expresar el identificador del documento relacionado con el pago. Este dato puede ser un Folio Fiscal de la Factura Electrónica o bien el número de operación de un documento digital.
        // </summary>
        public string IdDocumento {
            get { return this.idDocumento; }
            set { this.idDocumento = value; }
        }
        // <xs:attribute name="IdDocumento" use="required">
        //   <xs:annotation>
        //       <xs:documentation>
        //           Atributo requerido para expresar el identificador del documento relacionado con el pago. Este dato puede ser un Folio Fiscal de la Factura Electrónica o bien el número de operación de un documento digital.
        //       </xs:documentation>
        //   </xs:annotation>
        //   <xs:simpleType>
        //       <xs:restriction base="xs:string">
        //           <xs:minLength value="16"/>
        //           <xs:maxLength value="36"/>
        //           <xs:whiteSpace value="collapse"/>
        //           <xs:pattern value="([a-f0-9A-F]{8}-[a-f0-9A-F]{4}-[a-f0-9A-F]{4}-[a-f0-9A-F]{4}-[a-f0-9A-F]{12})|([0-9]{3}-[0-9]{2}-[0-9]{9})"/>
        //       </xs:restriction>
        //   </xs:simpleType>
        // </xs:attribute>


        // Serie
        // <summary>
        // Atributo opcional para precisar la serie del comprobante para control interno del contribuyente, acepta una cadena de caracteres.
        // </summary>
        public string Serie {
            get { return this.serie; }
            set { this.serie = value; }
        }
        // <xs:attribute name="Serie" use="optional">
        //   <xs:annotation>
        //       <xs:documentation>
        //           Atributo opcional para precisar la serie del comprobante para control interno del contribuyente, acepta una cadena de caracteres.
        //       </xs:documentation>
        //   </xs:annotation>
        //   <xs:simpleType>
        //       <xs:restriction base="xs:string">
        //           <xs:minLength value="1"/>
        //           <xs:maxLength value="25"/>
        //           <xs:whiteSpace value="collapse"/>
        //           <xs:pattern value="[^|]{1,25}"/>
        //       </xs:restriction>
        //   </xs:simpleType>
        // </xs:attribute>


        // Folio
        // <summary>
        // Atributo opcional para precisar el folio del comprobante para control interno del contribuyente, acepta una cadena de caracteres.
        // </summary>
        public string Folio {
            get { return this.folio; }
            set { this.folio = value; }
        }
        // <xs:attribute name="Folio" use="optional">
        //  <xs:annotation>
        //      <xs:documentation>
        //          Atributo opcional para precisar el folio del comprobante para control interno del contribuyente, acepta una cadena de caracteres.
        //      </xs:documentation>
        //  </xs:annotation>
        //  <xs:simpleType>
        //      <xs:restriction base="xs:string">
        //          <xs:minLength value="1"/>
        //          <xs:maxLength value="40"/>
        //          <xs:whiteSpace value="collapse"/>
        //          <xs:pattern value="[^|]{1,40}"/>
        //      </xs:restriction>
        //  </xs:simpleType>
        // </xs:attribute>


        // MonedaDr
        // <summary>
        // Atributo requerido para identificar la clave de la moneda utilizada en los importes del documento relacionado, cuando se usa moneda nacional 
        // o el documento relacionado no especifica la moneda se registra MXN. Los importes registrados en los atributos “ImpSaldoAnt”, “ImpPagado” e 
        // “ImpSaldoInsoluto” de éste nodo, deben corresponder a esta moneda. Conforme con la especificación ISO 4217.
        // </summary>
        public string MonedaDR {
            get { return this.monedaDR; }
            set { this.monedaDR = value; }
        }
        // <xs:attribute name="MonedaDR" use="required" type="catCFDI:c_Moneda">
        //  <xs:annotation>
        //      <xs:documentation>
        //          Atributo requerido para identificar la clave de la moneda utilizada en los importes del documento relacionado, cuando se usa moneda nacional
        //          o el documento relacionado no especifica la moneda se registra MXN. Los importes registrados en los atributos “ImpSaldoAnt”, “ImpPagado” e 
        //          “ImpSaldoInsoluto” de éste nodo, deben corresponder a esta moneda. Conforme con la especificación ISO 4217.
        //      </xs:documentation>
        //   </xs:annotation>
        // </xs:attribute>

        // TipoCambioDr
        // <summary>
        // Atributo condicional para expresar el tipo de cambio conforme con la moneda registrada en el documento relacionado. Es requerido cuando la moneda del 
        // documento relacionado es distinta de la moneda de pago. Se debe registrar el número de unidades de la moneda señalada en el documento relacionado que
        // equivalen a una unidad de la moneda del pago. Por ejemplo: El documento relacionado se registra en USD El pago se realiza por 100 EUR. Este atributo 
        // se registra como 1.114700 USD/EUR. El importe pagado equivale a 100 EUR * 1.114700 USD/EUR = 111.47 USD.
        // </summary>
        public decimal TipoCambioDR {
            get { return this.tipoCambioDR; }
            set { this.tipoCambioDR = value; }
        }
        // <xs:attribute name="TipoCambioDR" use="optional">
        //  <xs:annotation>
        //      <xs:documentation>
        //          Atributo condicional para expresar el tipo de cambio conforme con la moneda registrada en el documento relacionado. Es requerido cuando la moneda del 
        //          documento relacionado es distinta de la moneda de pago. Se debe registrar el número de unidades de la moneda señalada en el documento relacionado que
        //          equivalen a una unidad de la moneda del pago. Por ejemplo: El documento relacionado se registra en USD El pago se realiza por 100 EUR. Este atributo 
        //          se registra como 1.114700 USD/EUR. El importe pagado equivale a 100 EUR * 1.114700 USD/EUR = 111.47 USD.
        //      </xs:documentation>
        //  </xs:annotation>
        //  <xs:simpleType>
        //      <xs:restriction base="xs:decimal">
        //          <xs:fractionDigits value="6"/>
        //          <xs:minInclusive value="0.000001"/>
        //          <xs:whiteSpace value="collapse"/>
        //      </xs:restriction>
        //  </xs:simpleType>
        // </xs:attribute>


        // MetodoDePagoDR
        // <summary>
        // Atributo requerido para expresar la clave del método de pago que se registró en el documento relacionado.
        // </summary>
        public string MetodoDePagoDR {
            get { return this.metodoDePagoDR; }
            set { this.metodoDePagoDR = value; }
        }
        // <xs:attribute name="MetodoDePagoDR" use="required" type="catCFDI:c_MetodoPago">
        //  <xs:annotation>
        //      <xs:documentation>
        //          Atributo requerido para expresar la clave del método de pago que se registró en el documento relacionado.
        //      </xs:documentation>
        //  </xs:annotation>
        // </xs:attribute>

        // NumParcialidad
        // <summary>
        // Atributo condicional para expresar el número de parcialidad que corresponde al pago. Es requerido cuando MetodoDePagoDR contiene: “PPD” Pago en parcialidades o diferido.
        // </summary>
        public int NumParcialidades {
            get { return this.numParcialidades; }
            set { this.numParcialidades = value; }
        }
        // <xs:attribute name="NumParcialidad" use="optional">
        //  <xs:annotation>
        //      <xs:documentation>
        //          Atributo condicional para expresar el número de parcialidad que corresponde al pago. Es requerido cuando MetodoDePagoDR contiene: “PPD” Pago en parcialidades o diferido.
        //      </xs:documentation>
        //  </xs:annotation>
        //  <xs:simpleType>
        //      <xs:restriction base="xs:integer">
        //          <xs:whiteSpace value="collapse"/>
        //          <xs:pattern value="[1-9][0-9]{0,2}"/>
        //      </xs:restriction>
        //  </xs:simpleType>
        // </xs:attribute>


        // ImpSaldAnt
        // <summary>
        // Atributo condicional para expresar el monto del saldo insoluto de la parcialidad anterior. Es requerido cuando MetodoDePagoDR contiene: “PPD” Pago en parcialidades o diferido.
        // En el caso de que sea la primer parcialidad este campo debe contener el importe total del documento relacionado.
        // </summary>
        public decimal ImpSaldAnt {
            get { return this.impSaldAnt; }
            set { this.impSaldAnt = value; }
        }
        // <xs:attribute name="ImpSaldoAnt" use="optional" type="tdCFDI:t_Importe">
        //  <xs:annotation>
        //      <xs:documentation>
        //          Atributo condicional para expresar el monto del saldo insoluto de la parcialidad anterior. Es requerido cuando MetodoDePagoDR contiene: “PPD” Pago en parcialidades o diferido.
        //          En el caso de que sea la primer parcialidad este campo debe  contener el importe total del documento relacionado.
        //      </xs:documentation>
        //  </xs:annotation>
        // </xs:attribute>


        // ImpPagado
        // <summary>
        // Atributo condicional para expresar el importe pagado para el documento relacionado. Es obligatorio cuando exista más de un documento relacionado o cuando existe un documento relacionado y el TipoCambioDR tiene un valor.
        // </summary>
        public decimal ImpPagado {
            get { return this.impPagado; }
            set { this.impPagado = value; }
        }
        // <xs:attribute name="ImpPagado" use="optional" type="tdCFDI:t_Importe">
        //  <xs:annotation>
        //      <xs:documentation>
        //          Atributo condicional para expresar el importe pagado para el documento relacionado. Es obligatorio cuando exista más de un documento relacionado o cuando existe un documento relacionado y el TipoCambioDR tiene un valor.
        //      </xs:documentation>
        //  </xs:annotation>
        // </xs:attribute>


        // ImpSaldoInsoluto
        // <summary>
        // Atributo condicional para expresar la diferencia entre el importe del saldo anterior y el monto del pago. Es requerido cuando MetodoDePagoDR contiene: “PPD” Pago en parcialidades o diferido.
        // </summary>
        public decimal ImpSaldoInsoluto {
            get { return this.impSaldoInsoluto; }
            set { this.impSaldoInsoluto = value; }
        }
        // <xs:attribute name="ImpSaldoInsoluto" use="optional" type="tdCFDI:t_Importe">
        //  <xs:annotation>
        //      <xs:documentation>
        //          Atributo condicional para expresar la diferencia entre el importe del saldo anterior y el monto del pago. Es requerido cuando MetodoDePagoDR contiene: “PPD” Pago en parcialidades o diferido.
        //      </xs:documentation>
        //  </xs:annotation>
        // </xs:attribute>


        public int Ordinal {
            get { return this.ordinal; }
            set { this.ordinal = value; }
        }
    }
}