namespace PrevisaoTempo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCidadeEstadoRelationship : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cidade", "EstadoId");
            AddForeignKey("dbo.Cidade", "EstadoId", "dbo.Estado", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cidade", "EstadoId", "dbo.Estado");
            DropIndex("dbo.Cidade", new[] { "EstadoId" });
        }
    }
}
