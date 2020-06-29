using Microsoft.EntityFrameworkCore.Migrations;

namespace Liftoff_ChooseYourOwnAdventure.Migrations
{
    public partial class StoryboardSpecialCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Storyboards",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Story = table.Column<string>(nullable: true),
                    Option1 = table.Column<string>(nullable: true),
                    NextStoryboardID1 = table.Column<int>(nullable: false),
                    Option2 = table.Column<string>(nullable: true),
                    NextStoryboardID2 = table.Column<int>(nullable: false),
                    Special = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storyboards", x => x.ID);
                }) ;
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "Storyboards");
        }
    }
}
