namespace Airport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFlightinfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flight_info",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Url = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Flight_info");
        }
    }
}
