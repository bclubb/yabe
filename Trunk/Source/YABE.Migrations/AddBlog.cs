
/*****************************************
*	Migrations based on Migrator.NET
*	http://code.google.com/p/migratordotnet/
*****************************************/

namespace YABE.Migrations
{
    using System.Data;
    using Migrator.Framework;

    [Migration(20080929090852)]
    public class AddBlog : Migration
    {
        public override void Up()
        {
            Database.AddTable("YABE_Blog",
                new Column("Id", DbType.Int32, ColumnProperty.PrimaryKeyWithIdentity),
                new Column("Host", DbType.AnsiString, 50, ColumnProperty.NotNull),
                new Column("SubPath", DbType.AnsiString, 50, ColumnProperty.NotNull)
                );

            Database.AddUniqueConstraint("Host_SubPath", "YABE_Blog", new[] { "Host", "SubPath" });
        }

        public override void Down()
        {
            Database.RemoveConstraint("YABE_Blog", "Host_SubPath");

            Database.RemoveTable("YABE_Blog");
        }
    }
}