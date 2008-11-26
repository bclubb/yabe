
 /*****************************************
* Migrations based on Migrator.NET
* http://code.google.com/p/migratordotnet/
*****************************************/

namespace YABE.Migrations
{
    using System.Data;
    using Migrator.Framework;

    [Migration(20081030102820)]
    public class DropBlogSubPath : Migration
    {
        public override void Up()
        {
            Database.RemoveConstraint("YABE_Blog", "Host_SubPath");
            Database.RemoveColumn("YABE_Blog", "SubPath");
        }
        public override void Down()
        {
            Database.AddColumn("YABE_Blog", new Column("SubPath", DbType.AnsiString, 50, ColumnProperty.NotNull));
            Database.AddUniqueConstraint("Host_SubPath", "YABE_Blog", new[] { "Host", "SubPath" });
        }
    }
}