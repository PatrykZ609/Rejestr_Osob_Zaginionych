namespace Rejestr_Osob_Zaginionych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingRolesData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Roles(Title) VALUES('Administration')");
            Sql("Insert INTO Roles(Title) VALUES('User')");
            Sql("Insert INTO Roles(Title) VALUES('Client')");
        }
        
        public override void Down()
        {
        }
    }
}
