namespace Rejestr_Osob_Zaginionych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDataValidationToOsobas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Osobas", "Imię", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Osobas", "Nazwisko", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Osobas", "Płeć", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Osobas", "Ostatnie_miejsce_pobytu", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Osobas", "Województwo", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Osobas", "Województwo", c => c.String());
            AlterColumn("dbo.Osobas", "Ostatnie_miejsce_pobytu", c => c.String());
            AlterColumn("dbo.Osobas", "Płeć", c => c.String());
            AlterColumn("dbo.Osobas", "Nazwisko", c => c.String());
            AlterColumn("dbo.Osobas", "Imię", c => c.String());
        }
    }
}
