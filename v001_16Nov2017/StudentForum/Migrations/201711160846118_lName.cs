namespace StudentForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "fName", c => c.String());
            AddColumn("dbo.AspNetUsers", "lName", c => c.String());
            AddColumn("dbo.AspNetUsers", "studentNr", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "studentNr");
            DropColumn("dbo.AspNetUsers", "lName");
            DropColumn("dbo.AspNetUsers", "fName");
        }
    }
}
