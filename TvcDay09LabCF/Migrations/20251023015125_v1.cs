using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TvcDay09LabCF.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblLoaiSanPham",
                columns: table => new
                {
                    IDLoaiSanPham = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLoaiSanPham", x => x.IDLoaiSanPham);
                });

            migrationBuilder.CreateTable(
                name: "tblSanPham",
                columns: table => new
                {
                    IDSanPham = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSanPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoaiSanPhamID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSanPham", x => x.IDSanPham);
                    table.ForeignKey(
                        name: "FK_tblSanPham_TblLoaiSanPham_LoaiSanPhamID",
                        column: x => x.LoaiSanPhamID,
                        principalTable: "TblLoaiSanPham",
                        principalColumn: "IDLoaiSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblLoaiSanPham_MaLoai",
                table: "TblLoaiSanPham",
                column: "MaLoai",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblSanPham_LoaiSanPhamID",
                table: "tblSanPham",
                column: "LoaiSanPhamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblSanPham");

            migrationBuilder.DropTable(
                name: "TblLoaiSanPham");
        }
    }
}
