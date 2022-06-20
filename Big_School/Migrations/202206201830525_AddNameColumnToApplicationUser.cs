namespace Big_School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToApplicationUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Lecturrer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "Lecturrer_Id" });
            RenameColumn(table: "dbo.Courses", name: "Lecturrer_Id", newName: "LecturerId");
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Courses", "LecturerId");
            AddForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.Courses", "LectureID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "LectureID", c => c.String(nullable: false));
            DropForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(maxLength: 128));
            DropColumn("dbo.AspNetUsers", "Name");
            RenameColumn(table: "dbo.Courses", name: "LecturerId", newName: "Lecturrer_Id");
            CreateIndex("dbo.Courses", "Lecturrer_Id");
            AddForeignKey("dbo.Courses", "Lecturrer_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
