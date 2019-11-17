namespace SpeechPrep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatchUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Company", c => c.Int(nullable: false));
            AddColumn("dbo.Questions", "Core", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "Core");
            DropColumn("dbo.Questions", "Company");
        }
    }
}
