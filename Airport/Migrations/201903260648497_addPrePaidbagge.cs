namespace Airport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPrePaidbagge : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pre_Paidbagge",
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
            DropTable("dbo.Pre_Paidbagge");
        }
    }
}
