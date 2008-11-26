using Migrator;

[Migration(1)]
public class SchemaDump : Migration
{
	public override void Up()
	{
		Database.AddTable("sysdiagrams",
			new Column("name", typeof(String)),
			new Column("principal_id", typeof(String)),
			new Column("diagram_id", typeof(String)),
			new Column("version", typeof(String)),
			new Column("definition", typeof(String)),
		);
		Database.AddTable("SchemaInfo",
			new Column("Version", typeof(String)),
		);
		Database.AddTable("YABE_Blog",
			new Column("Id", typeof(String)),
			new Column("Host", typeof(String)),
			new Column("SubPath", typeof(String)),
		);
		Database.AddTable("YABE_Post",
			new Column("Id", typeof(String)),
			new Column("Title", typeof(String)),
			new Column("Text", typeof(String)),
			new Column("IsPublished", typeof(String)),
			new Column("DateCreated", typeof(String)),
			new Column("BlogId", typeof(String)),
		);
	}

	public override void Down()
	{
		Database.RemoveTable("sysdiagrams");
		Database.RemoveTable("SchemaInfo");
		Database.RemoveTable("YABE_Blog");
		Database.RemoveTable("YABE_Post");
	}
}
