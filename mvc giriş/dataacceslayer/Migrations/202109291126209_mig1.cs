namespace dataacceslayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.contents", "WriterID", c => c.Int());
            CreateIndex("dbo.contents", "WriterID");
            AddForeignKey("dbo.contents", "WriterID", "dbo.writers", "WriterID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.contents", "WriterID", "dbo.writers");
            DropIndex("dbo.contents", new[] { "WriterID" });
            DropColumn("dbo.contents", "WriterID");
        }
    }
}
