
 /*****************************************
* Migrations based on Migrator.NET
* http://code.google.com/p/migratordotnet/
*****************************************/

namespace YABE.Migrations
{
    using System.Data;
    using Migrator.Framework;

    [Migration(20081013154123)]
    public class AddNumberOfPostsToShowOnHomePageToBlog : Migration
    {
        public override void Up()
        {
            Database.AddColumn("YABE_Blog", new Column("NumberOfPostsToShowOnHomePage", DbType.Int32));
        }
        public override void Down()
        {
            Database.RemoveColumn("YABE_Blog", "NumberOfPostsToShowOnHomePage");
        }
    }
}