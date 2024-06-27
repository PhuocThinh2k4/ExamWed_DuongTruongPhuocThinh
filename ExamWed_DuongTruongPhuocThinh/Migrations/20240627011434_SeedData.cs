using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWed_DuongTruongPhuocThinh.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaNhacs",
                columns: new[] { "Id", "NgheSi", "TheLoai", "SoLuong", "GiaBan", "TuaDe" },
                values: new object[,]
                {
                    { 1, "A", 105000.0, 110, true, "CD Nỗi buồn gác trọ" },
                    { 2, "V", 250000.0, 161, false, "CD Bài tình ca đêm" },
                    { 3, "R", 230000.0, 105, true, "CD BABYMONSTER" },
                    { 4, "B", 150000.0, 150, true, "CD Chuyện chúng mình" },
                    { 5, "T", 27000.0, 120, true, "CD Today's US-UK Hit" },
                    { 6, "G", 220000.0, 107, false, "CD Đoá hồng nhạc Việt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
