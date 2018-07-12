namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1/1/1980' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
