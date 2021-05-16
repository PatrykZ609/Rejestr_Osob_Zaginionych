namespace Rejestr_Osob_Zaginionych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingWojewodztwoClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Wojewodztwoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Osobas", "WojewodztwoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Osobas", "WojewodztwoId");
            AddForeignKey("dbo.Osobas", "WojewodztwoId", "dbo.Wojewodztwoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Osobas", "WojewodztwoId", "dbo.Wojewodztwoes");
            DropIndex("dbo.Osobas", new[] { "WojewodztwoId" });
            DropColumn("dbo.Osobas", "WojewodztwoId");
            DropTable("dbo.Wojewodztwoes");
        }
    }
}
