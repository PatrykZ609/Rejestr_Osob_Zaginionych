namespace Rejestr_Osob_Zaginionych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveWojewodztwoColumnFromProduct : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Osobas", "Województwo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Osobas", "Województwo", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
