namespace _024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v03 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
