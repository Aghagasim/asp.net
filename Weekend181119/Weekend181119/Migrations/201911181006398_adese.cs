namespace Weekend181119.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adese : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactForms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EmailAddress = c.String(),
                        PhoneNumber = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SamplePosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Subtitle = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Navbar = c.String(),
                        ContactText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SosialLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MyProperty = c.Int(nullable: false),
                        SettingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Settings", t => t.SettingId, cascadeDelete: true)
                .Index(t => t.SettingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SosialLinks", "SettingId", "dbo.Settings");
            DropIndex("dbo.SosialLinks", new[] { "SettingId" });
            DropTable("dbo.SosialLinks");
            DropTable("dbo.Settings");
            DropTable("dbo.SamplePosts");
            DropTable("dbo.ContactForms");
        }
    }
}
