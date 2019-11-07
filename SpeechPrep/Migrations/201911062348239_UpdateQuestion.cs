namespace SpeechPrep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateQuestion : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Questions ON");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (1, 'What are your greatest strengths?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (2, 'What are your greatest weaknesses?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (3, 'Tell me about yourself.', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (4, 'How do you handle stress and pressure?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (5, 'Describe a difficult work situation or project and how you overcame it.', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (6, 'What motivates you?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (7, 'Are you overqualified for this job?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (8, 'Why are you leaving or why have you left your job?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (9, 'Why do you want this job?', 'Null')");
            Sql("INSERT INTO Questions (Id, InterviewQuestion, StarType) VALUES (10, 'Why should we hire you?', 'Null')");
            Sql("SET IDENTITY_INSERT Questions OFF");
        }
        
        public override void Down()
        {
        }
    }
}
