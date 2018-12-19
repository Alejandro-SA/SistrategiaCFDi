using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistrategia.SAT.CFDiWebSite.CFDI
{
    public class ComprobantePagos : Complemento
    {
        private string version { get; set; }
        private string status { get; set; }
        private List<ComprobantePago> comprobantes { get; set; }

        // Version
        // <summary>
        // Atributo requerido que indica la versión del complemento para recepción de pagos.
        // </summary>
        // <remarks>
        // Valor fijado a "1.0"
        // </remarks>
        public string Version
        {
            get { return this.version; }
            set { this.version = value; }
        }
        //<xs:attribute name="Version" use="required" fixed="1.0">
        //  <xs:annotation>
        //    <xs:documentation>
        //      Atributo requerido que indica la versión del complemento para recepción de pagos.
        //    </xs:documentation>
        //  </xs:annotation>
        //  <xs:simpleType>
        //    <xs:restriction base="xs:string">
        //      <xs:whiteSpace value="collapse"/>
        //    </xs:restriction>
        //  </xs:simpleType>
        //</xs:attribute>


        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public List<ComprobantePago> Comprobantes
        {
            get { return this.comprobantes; }
            set { this.comprobantes = value; }
        }
    }
}