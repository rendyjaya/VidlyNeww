namespace VidlyNeww.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTimePropertiesToCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
            DropTable("dbo.Movies");
        }
    }
}
