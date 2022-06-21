namespace Big_School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (ID, NAME) VALUES (1, 'Development')");
            Sql("INSERT INTO Categories (ID, NAME) VALUES (2, 'Business')");
            Sql("INSERT INTO Categories (ID, NAME) VALUES (3, 'Marketing')");
            Sql("INSERT INTO Categories (ID, NAME) VALUES (4, 'Information Technology')");
            Sql("INSERT INTO Categories (ID, NAME) VALUES (5, 'Biomedical Engineering')");
            Sql("INSERT INTO Categories (ID, NAME) VALUES (6, 'Business English')");
            Sql("INSERT INTO Categories (ID, NAME) VALUES (7, 'Accounting')");
            Sql("INSERT INTO Categories (ID, NAME) VALUES (8, 'Finance and Banking')");
            Sql("INSERT INTO Categories (ID, NAME) VALUES (9, 'Mechanical Engineering')");
        }
        
        public override void Down()
        {
        }
    }
}
