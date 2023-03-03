namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMedication : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medications", "ViewInfo", c => c.String());
            DropColumn("dbo.Medications", "Path");
            DropColumn("dbo.Medications", "View");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medications", "View", c => c.String());
            AddColumn("dbo.Medications", "Path", c => c.String());
            DropColumn("dbo.Medications", "ViewInfo");
        }
    }
}
