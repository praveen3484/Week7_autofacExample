namespace ClassLibrary1.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.Employee2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false),
                        Phone = c.Long(nullable: false),
                        MaritalStatus = c.Boolean(nullable: false),
                        State = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        image = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.State1",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.StateId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.State1");
            DropTable("dbo.Images");
            DropTable("dbo.Employee2");
            DropTable("dbo.Cities");
        }
    }
}
