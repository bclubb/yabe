
 /*****************************************
* Migrations based on Migrator.NET
* http://code.google.com/p/migratordotnet/
*****************************************/

namespace YABE.Migrations
{
    using System.Data;
    using Migrator.Framework;

    [Migration(20081014170112)]
    public class AddDatePublishedToPost : Migration
    {
        public override void Up()
        {
            Database.AddColumn("YABE_Post", new Column("DatePublished", DbType.Date, ColumnProperty.None));
            Database.RemoveColumn("YABE_Post", "IsPublished");
        }
        public override void Down()
        {
            Database.RemoveColumn("YABE_Post", "DatePublished");
            Database.AddColumn("YABE_Post", new Column("IsPublished", DbType.Boolean, false));
        }
    }
}