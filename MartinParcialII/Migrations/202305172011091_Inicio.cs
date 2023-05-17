namespace MartinParcialII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Docentes",
                c => new
                    {
                        DocenteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Aula = c.String(nullable: false, maxLength: 50),
                        LaptopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DocenteId)
                .ForeignKey("dbo.Laptops", t => t.LaptopId)
                .Index(t => t.LaptopId);
            
            CreateTable(
                "dbo.Laptops",
                c => new
                    {
                        LaptopId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Marca = c.String(nullable: false, maxLength: 50),
                        MemoriaRam = c.String(nullable: false, maxLength: 50),
                        Procesador = c.String(nullable: false, maxLength: 50),
                        Disco = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.LaptopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Docentes", "LaptopId", "dbo.Laptops");
            DropIndex("dbo.Docentes", new[] { "LaptopId" });
            DropTable("dbo.Laptops");
            DropTable("dbo.Docentes");
        }
    }
}
