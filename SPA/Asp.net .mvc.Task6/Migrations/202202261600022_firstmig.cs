namespace Asp.net.mvc.Task6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Departmentid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Departmentid);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        age = c.Int(),
                        Departmentid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.Departmentid, cascadeDelete: true)
                .Index(t => t.Departmentid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Departmentid", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Departmentid" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
