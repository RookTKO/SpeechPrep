namespace SpeechPrep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Favorite", c => c.Boolean(nullable: false));
            AddColumn("dbo.Questions", "SavedForLater", c => c.Boolean(nullable: false));
            AddColumn("dbo.Questions", "Completed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "Completed");
            DropColumn("dbo.Questions", "SavedForLater");
            DropColumn("dbo.Questions", "Favorite");
        }
    }
}
