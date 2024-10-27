namespace Project2WooxTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Rezervations", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rezervations", "Email", c => c.String());
        }
    }
}
