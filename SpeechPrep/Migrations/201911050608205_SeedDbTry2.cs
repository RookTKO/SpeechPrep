namespace SpeechPrep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDbTry2 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Questions ON");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (0, 'What are your greatest strengths?', 'Null')");
            Sql("SET IDENTITY_INSERT Questions OFF");
        }
        
        public override void Down()
        {
        }
    }
}
