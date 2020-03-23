namespace EFStudiiDeCaz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SelfReferences", "ParentSelfReferenceId", "dbo.SelfReferences");
            DropIndex("dbo.SelfReferences", new[] { "ParentSelfReferenceId" });
            CreateTable(
                "BazaDeDate.Product",
                c => new
                    {
                        SKU = c.Int(nullable: false),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SKU);
            
            CreateTable(
                "BazaDeDate.ProductWebInfo",
                c => new
                    {
                        SKU = c.Int(nullable: false),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.SKU)
                .ForeignKey("BazaDeDate.Product", t => t.SKU)
                .Index(t => t.SKU);
            
            DropTable("dbo.SelfReferences");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SelfReferences",
                c => new
                    {
                        SelfReferenceId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParentSelfReferenceId = c.Int(),
                    })
                .PrimaryKey(t => t.SelfReferenceId);
            
            DropForeignKey("BazaDeDate.ProductWebInfo", "SKU", "BazaDeDate.Product");
            DropIndex("BazaDeDate.ProductWebInfo", new[] { "SKU" });
            DropTable("BazaDeDate.ProductWebInfo");
            DropTable("BazaDeDate.Product");
            CreateIndex("dbo.SelfReferences", "ParentSelfReferenceId");
            AddForeignKey("dbo.SelfReferences", "ParentSelfReferenceId", "dbo.SelfReferences", "SelfReferenceId");
        }
    }
}
