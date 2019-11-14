namespace SpeechPrep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateQuestion : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Questions ON");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (3, 'What are your greatest weaknesses?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (4, 'Describe a difficult work situation or project and how you overcame it.', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (5, 'What motivates you?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (6, 'Are you overqualified for this job?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (7, 'Why are you leaving or why have you left your job?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (8, 'Why do you want this job?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (9, 'Why should we hire you?', 'Null')");
            Sql("SET IDENTITY_INSERT Questions OFF");
        }
        
        public override void Down()
        {
        }
    }
}
