
 /*****************************************
* Migrations based on Migrator.NET
* http://code.google.com/p/migratordotnet/
*****************************************/

namespace YABE.Migrations
{
    using System.Data;
    using Migrator.Framework;

    [Migration(20081015134052)]
    public class AddSlugToPost : Migration
    {
        public override void Up()
        {
            Database.AddColumn("YABE_Post", new Column("Slug", DbType.AnsiString, 255));
        }
        public override void Down()
        {
            Database.RemoveColumn("YABE_Post", "Slug");
        }
    }
}