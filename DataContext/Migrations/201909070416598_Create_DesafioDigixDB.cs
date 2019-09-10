namespace DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_DesafioDigixDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Familia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Tipo = c.Int(nullable: false),
                        FamiliaId = c.Int(nullable: false),
                        DataDeNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Familia", t => t.FamiliaId, cascadeDelete: true)
                .Index(t => t.FamiliaId);
            
            CreateTable(
                "dbo.Renda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PessoaId = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId, cascadeDelete: true)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Renda", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Pessoa", "FamiliaId", "dbo.Familia");
            DropIndex("dbo.Renda", new[] { "PessoaId" });
            DropIndex("dbo.Pessoa", new[] { "FamiliaId" });
            DropTable("dbo.Renda");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Familia");
        }
    }
}
