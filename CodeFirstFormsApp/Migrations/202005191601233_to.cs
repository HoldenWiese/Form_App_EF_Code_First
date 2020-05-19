namespace CodeFirstFormsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class to : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalesPersons", "UpdatedBy", c => c.String(nullable: false));
            AddColumn("dbo.SalesRegions", "UpdatedBy", c => c.String(nullable: false));
            AddColumn("dbo.Sales", "UpdatedBy", c => c.String(nullable: false));
            DropColumn("dbo.SalesPersons", "UpdateBy");
            DropColumn("dbo.SalesRegions", "UpdateBy");
            DropColumn("dbo.Sales", "UpdateBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "UpdateBy", c => c.String(nullable: false));
            AddColumn("dbo.SalesRegions", "UpdateBy", c => c.String(nullable: false));
            AddColumn("dbo.SalesPersons", "UpdateBy", c => c.String(nullable: false));
            DropColumn("dbo.Sales", "UpdatedBy");
            DropColumn("dbo.SalesRegions", "UpdatedBy");
            DropColumn("dbo.SalesPersons", "UpdatedBy");
        }
    }
}
