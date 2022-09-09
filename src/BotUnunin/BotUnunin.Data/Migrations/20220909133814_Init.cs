using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BotUnunin.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageOfUss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageOfUss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageOfUss_Loves_LoveId",
                        column: x => x.LoveId,
                        principalTable: "Loves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Loves",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Lần đầu gặp nàaaaaaa" },
                    { 2, "Lần thứ 2 nà tỏ tìnhh :3" },
                    { 3, "Đi chơi tháng đầu tiênnn" },
                    { 4, "Kỉ niệm tháng đầu tiênn" },
                    { 5, "Đi chơi tháng thứ haiiii" },
                    { 6, "Đi chơi tháng thứ baaa" },
                    { 7, "Đi chơi tháng thứ tư" },
                    { 8, "Đi chơi tháng thứ nămmm" },
                    { 9, "Đi chơi tháng thứ sáuuuuu" },
                    { 10, "Từ ngày xa bé đến giờ" }
                });

            migrationBuilder.InsertData(
                table: "ImageOfUss",
                columns: new[] { "Id", "Description", "LoveId", "Url" },
                values: new object[,]
                {
                    { 1, "Có người định trốn cơ đấy :)))))", 1, "1.jpeg" },
                    { 2, "Tỏ tình lại còn bày đặt suy nghĩiiii :3", 2, "2.png" },
                    { 3, "Anh thi mà khum giúp chỉ chụp ảnh", 3, "3.png" },
                    { 4, "", 3, "4.png" },
                    { 5, "Đi làm với đi học nà", 3, "51.jpg" },
                    { 6, "Dù lạnh vẫn đưa áo cho bé mặc :3", 3, "97.jpeg" },
                    { 7, "", 3, "78.jpg" },
                    { 8, "", 3, "80.jpg" },
                    { 9, "Đi về quê ăn tết có người khum muốn gặpp nà", 3, "82.jpeg" },
                    { 10, "", 3, "81.jpg" },
                    { 11, "", 3, "6.png" },
                    { 12, "Gặp nhao sau tếtt", 3, "94.jpeg" },
                    { 13, "", 3, "96.jpeg" },
                    { 14, "Lần đầu về nhà anhh", 3, "10.png" },
                    { 15, "", 3, "8.png" },
                    { 16, "", 3, "7.png" },
                    { 17, "", 3, "9.png" },
                    { 18, "Lần đầu đi xem phimm nà", 3, "11.png" },
                    { 19, "Valentine đầu tiênnn :3", 3, "12.png" },
                    { 20, "Kỉ niệm tháng đầu tiênnnn", 4, "13.png" },
                    { 21, "", 4, "14.png" },
                    { 22, "", 5, "15.png" },
                    { 23, "", 5, "16.png" },
                    { 24, "", 5, "14.png" },
                    { 25, "", 3, "83.jpg" },
                    { 26, "", 3, "84.jpg" },
                    { 27, "Đưa bé đi tiêmm", 4, "98.jpg" },
                    { 28, "", 4, "99.jpg" },
                    { 29, "Anh bị covidd :(", 5, "57.png" },
                    { 30, "", 6, "53.jpg" },
                    { 31, "", 6, "58.jpeg" },
                    { 32, "Đi đạp xe đạppp", 6, "56.JPEG" },
                    { 33, "", 6, "22.png" },
                    { 34, "", 6, "23.png" },
                    { 35, "", 6, "65.jpg" },
                    { 36, "", 6, "66.jpg" },
                    { 37, "", 6, "68.jpg" },
                    { 38, "", 6, "69.jpeg" },
                    { 39, "Đạp vịt nàaa", 6, "70.jpeg" },
                    { 40, "", 6, "71.jpg" },
                    { 41, "Đi Sóc Sơnnnnnnn", 6, "72.jpg" },
                    { 42, "", 6, "73.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ImageOfUss",
                columns: new[] { "Id", "Description", "LoveId", "Url" },
                values: new object[,]
                {
                    { 43, "", 6, "75.jpg" },
                    { 44, "", 6, "79.jpg" },
                    { 45, "Đi tô tượnggg", 7, "60.jpeg" },
                    { 46, "Đi Thiên Đường Bảo Sơn nàaaa", 7, "86.jpeg" },
                    { 47, "", 7, "87.jpeg" },
                    { 48, "", 7, "88.jpeg" },
                    { 49, "", 7, "89.jpeg" },
                    { 50, "", 7, "90.jpg" },
                    { 51, "", 7, "62.jpeg" },
                    { 52, "Lần đầu đến trườngggg nà", 8, "31.png" },
                    { 53, "Đi xem Vũ hátt", 8, "63.jpeg" },
                    { 54, "", 8, "55.jpg" },
                    { 55, "1/6 Bên bé nàaa", 8, "90.jpg" },
                    { 56, "", 6, "34.jpg" },
                    { 57, "Anh bảo mệt là bé đến bênnn", 6, "24.png" },
                    { 58, "", 7, "30.png" },
                    { 59, "", 7, "32.png" },
                    { 60, "", 7, "29.png" },
                    { 61, "", 7, "30.png" },
                    { 62, "", 8, "33.png" },
                    { 63, "Đi Hải Phònggggg", 8, "35.png" },
                    { 64, "", 8, "36.png" },
                    { 65, "", 7, "27.png" },
                    { 66, "", 8, "64.jpeg" },
                    { 67, "", 8, "67.jpg" },
                    { 68, "", 8, "91.jpg" },
                    { 69, "", 8, "37.png" },
                    { 70, "", 8, "38.png" },
                    { 71, "", 9, "39.png" },
                    { 72, "", 9, "40.png" },
                    { 73, "", 9, "40.png" },
                    { 74, "", 9, "41.png" },
                    { 75, "", 9, "42.png" },
                    { 76, "Đi Hạ Long nàaaa", 9, "43.png" },
                    { 77, "", 9, "44.png" },
                    { 78, "", 9, "45.png" },
                    { 79, "", 9, "92.jpeg" },
                    { 80, "", 9, "74.jpeg" },
                    { 81, "", 9, "76.jpg" },
                    { 82, "", 9, "77.jpeg" },
                    { 83, "", 9, "93.jpg" },
                    { 84, "", 10, "100.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ImageOfUss",
                columns: new[] { "Id", "Description", "LoveId", "Url" },
                values: new object[,]
                {
                    { 85, "", 10, "47.png" },
                    { 86, "", 10, "48.png" },
                    { 87, "", 10, "59.jpeg" },
                    { 88, "", 10, "47.png" },
                    { 89, "", 10, "49.png" },
                    { 90, "", 10, "50.png" },
                    { 91, "", 10, "61.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageOfUss_LoveId",
                table: "ImageOfUss",
                column: "LoveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageOfUss");

            migrationBuilder.DropTable(
                name: "Loves");
        }
    }
}
