namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RowVersion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Department", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            DropStoredProcedure("dbo.Department_Insert");
            DropStoredProcedure("dbo.Department_Update");
            DropStoredProcedure("dbo.Department_Delete");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Department", "RowVersion");
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
