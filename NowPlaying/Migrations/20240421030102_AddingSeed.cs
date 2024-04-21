using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NowPlaying.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ImageURL", "Rating", "RunTime", "Title" },
                values: new object[,]
                {
                    { 1, "In deep space, the crew of the commercial starship Nostromo is awakened from their cryo-sleep capsules halfway through their journey home to investigate a distress call from an alien vessel.", "https://upload.wikimedia.org/wikipedia/en/c/c3/Alien_movie_poster.jpg?20200710234615", "R", "1h 57m", "Alien" },
                    { 2, "In this 1980s sci-fi classic, small-town California teen Marty McFly (Michael J. Fox) is thrown back into the '50s when an experiment by his eccentric scientist friend Doc Brown (Christopher Lloyd) goes awry.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "PG", "1h 56m", "Back to the Future" },
                    { 3, "Adm. James T. Kirk (William Shatner) has defeated his archenemy but at great cost. His friend Spock has apparently been killed, the USS Enterprise is being scrapped, and starship physician Dr. Leonard \"Bones\" McCoy (DeForest Kelley) has taken ill. McCoy's odd behavior is evidence he's harboring Spock's katra, or animating spirit, and Kirk seeks to take the Enterprise back to the Genesis Planet and find his friend. Rebuffed, Kirk takes dramatic action that results in war with deadly Klingons.", "https://upload.wikimedia.org/wikipedia/en/b/b6/Star_Trek_III_The_Search_for_Spock.png", "PG", "1h 45m", "Star Trek III: The Search for Spock" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Movies");
        }
    }
}
