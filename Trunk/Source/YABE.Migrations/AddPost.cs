
 /*****************************************
*	Migrations based on Migrator.NET
*	http://code.google.com/p/migratordotnet/
*****************************************/

namespace YABE.Migrations
{
    using System.Data;
    using Migrator.Framework;
    using ForeignKeyConstraint=Migrator.Framework.ForeignKeyConstraint;

    [Migration(20080929142614)]
    public class AddPost : Migration
    {
        public override void Up()
        {
            Database.AddTable("YABE_Post",
                new Column("Id", DbType.Int32, ColumnProperty.PrimaryKeyWithIdentity),
                new Column("Title", DbType.AnsiString, 255),
                new Column("Text", DbType.AnsiString, 2147483647), // sets column to type VARCHAR(MAX)
                new Column("IsPublished", DbType.Boolean, false),
                new Column("DateCreated", DbType.Date, ColumnProperty.NotNull, "GETDATE()"),
                new Column("BlogId", DbType.Int32, ColumnProperty.NotNull)
                );

            Database.AddForeignKey("FK_Blog_Post", "YABE_Post", "BlogId", "YABE_Blog", "Id", ForeignKeyConstraint.NoAction);
        }

        public override void Down()
        {
            Database.RemoveForeignKey("YABE_Post", "FK_Blog_Post");
            Database.RemoveTable("YABE_Post");
        }
    }
}