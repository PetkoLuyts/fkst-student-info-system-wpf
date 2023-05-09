namespace StudentInfoSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialOne : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                        Subject = c.String(),
                    })
                .PrimaryKey(t => t.GradeId)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                        familyname = c.String(),
                        faculty = c.String(),
                        specialty = c.String(),
                        qualificationDegree = c.String(),
                        statusOfStudying = c.String(),
                        facultyNumber = c.String(),
                        course = c.Int(nullable: false),
                        potok = c.Int(nullable: false),
                        group = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        number = c.String(),
                        role = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        ActiveTill = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Grades", "StudentId", "dbo.Students");
            DropIndex("dbo.Grades", new[] { "StudentId" });
            DropTable("dbo.Users");
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
