namespace ClassLibrary1.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employee2", "Phone", c => c.Long());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee2", "Phone", c => c.Long(nullable: false));
        }
    }
}
