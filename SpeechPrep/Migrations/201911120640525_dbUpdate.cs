namespace SpeechPrep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbUpdate : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Questions ON");
            //Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (1, 'Tell me about yourself.', 'Null')");
            //Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (2, 'How do you handle stress and pressure?', 'Null')");
            Sql("SET IDENTITY_INSERT Questions OFF");
        }
        public override void Down()
        {
        }
    }
}
