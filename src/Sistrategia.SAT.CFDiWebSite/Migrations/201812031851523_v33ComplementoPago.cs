namespace Sistrategia.SAT.CFDiWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v33ComplementoPago : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sat_comprobante_pago_docto_relacionado",
                c => new
                    {
                        comprobante_pago_docto_relacionado_id = c.Guid(nullable: false),
                        id_documento = c.String(),
                        serie = c.String(),
                        folio = c.String(),
                        moneda_d_r = c.String(),
                        tipo_cambio_d_r = c.Decimal(nullable: false, precision: 18, scale: 2),
                        metodo_de_pago_d_r = c.String(),
                        num_parcialidades = c.Int(nullable: false),
                        imp_sald_ant = c.Decimal(nullable: false, precision: 18, scale: 2),
                        imp_pagado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        imp_saldo_insoluto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ordinal = c.Int(nullable: false),
                        comprobante_pago_id = c.Int(),
                    })
                .PrimaryKey(t => t.comprobante_pago_docto_relacionado_id)
                .ForeignKey("dbo.sat_comprobante_pago", t => t.comprobante_pago_id)
                .Index(t => t.comprobante_pago_id);
            
            CreateTable(
                "dbo.sat_comprobante_pago",
                c => new
                    {
                        complemento_id = c.Int(nullable: false),
                        version = c.String(),
                        fecha_pago = c.DateTime(nullable: false),
                        forma_de_pago = c.String(),
                        moneda_p = c.String(),
                        tipo_cambio_p = c.String(),
                        monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        num_operacion = c.String(),
                        rfc_emisor_cta_ord = c.String(),
                        nomb_banco_ord_ext = c.String(),
                        cta_ordenante = c.String(),
                        rfc_emisor_cta_ben = c.String(),
                        cta_beneficiario = c.String(),
                        tipo_cad_pago = c.String(),
                        cert_pago = c.String(),
                        cad_pago = c.String(),
                        sello_pago = c.String(),
                    })
                .PrimaryKey(t => t.complemento_id)
                .ForeignKey("dbo.sat_complemento", t => t.complemento_id)
                .Index(t => t.complemento_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.sat_comprobante_pago", "complemento_id", "dbo.sat_complemento");
            DropForeignKey("dbo.sat_comprobante_pago_docto_relacionado", "comprobante_pago_id", "dbo.sat_comprobante_pago");
            DropIndex("dbo.sat_comprobante_pago", new[] { "complemento_id" });
            DropIndex("dbo.sat_comprobante_pago_docto_relacionado", new[] { "comprobante_pago_id" });
            DropTable("dbo.sat_comprobante_pago");
            DropTable("dbo.sat_comprobante_pago_docto_relacionado");
        }
    }
}
