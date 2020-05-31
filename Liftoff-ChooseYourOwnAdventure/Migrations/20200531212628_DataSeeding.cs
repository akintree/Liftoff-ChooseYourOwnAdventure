using Microsoft.EntityFrameworkCore.Migrations;

namespace Liftoff_ChooseYourOwnAdventure.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    StoryboardID = table.Column<int>(nullable: true),
                    Story = table.Column<string>(nullable: true),
                    Option1 = table.Column<string>(nullable: true),
                    NextStoryboardID1 = table.Column<int>(nullable: true),
                    Option2 = table.Column<string>(nullable: true),
                    NextStoryboardID2 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
