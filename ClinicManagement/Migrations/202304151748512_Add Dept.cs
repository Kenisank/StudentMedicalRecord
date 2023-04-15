namespace ClinicManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDept : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "RegNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "RegNo");
        }
    }
}
