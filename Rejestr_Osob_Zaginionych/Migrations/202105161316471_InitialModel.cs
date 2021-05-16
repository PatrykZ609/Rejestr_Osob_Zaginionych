namespace Rejestr_Osob_Zaginionych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Osobas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Imię = c.String(),
                        Nazwisko = c.String(),
                        Wiek = c.Int(nullable: false),
                        Płeć = c.String(),
                        Ostatnie_miejsce_pobytu = c.String(),
                        Województwo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Osobas");
        }
    }
}
