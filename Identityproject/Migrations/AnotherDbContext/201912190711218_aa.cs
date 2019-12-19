namespace Identityproject.Migrations.AnotherDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        UniversityName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                        StreetAddress = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
