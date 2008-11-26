
 /*****************************************
* Migrations based on Migrator.NET
* http://code.google.com/p/migratordotnet/
*****************************************/

namespace YABE.Migrations
{
    using Migrator.Framework;

    [Migration(20081030102957)]
    public class AddBlogHostConstraint : Migration
    {
        public override void Up()
        {
            Database.AddUniqueConstraint("Host", "YABE_Blog", new[] { "Host"});
        }
        public override void Down()
        {
            Database.RemoveConstraint("YABE_Blog", "Host");
        }
    }
}