namespace ClassLibrary1.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration23 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee2", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee2", "Image");
        }
    }
}
