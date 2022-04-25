namespace PrevisaoTempo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPrevisaoClimaCidadeRelationship : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.PrevisaoClima", "CidadeId");
            AddForeignKey("dbo.PrevisaoClima", "CidadeId", "dbo.Cidade", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrevisaoClima", "CidadeId", "dbo.Cidade");
            DropIndex("dbo.PrevisaoClima", new[] { "CidadeId" });
        }
    }
}
