namespace ClassLibrary1.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employee2", "Phone", c => c.Long(nullable: false));
            AlterColumn("dbo.Employee2", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Employee2", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee2", "City", c => c.String());
            AlterColumn("dbo.Employee2", "State", c => c.String());
            AlterColumn("dbo.Employee2", "Phone", c => c.Long());
        }
    }
}
