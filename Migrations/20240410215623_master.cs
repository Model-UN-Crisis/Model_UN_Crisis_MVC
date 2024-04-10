using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model_UN_Crisis.Migrations
{
    /// <inheritdoc />
    public partial class master : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRD_Conferences",
                columns: table => new
                {
                    Iconference_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iprimary_Admin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRD_Conferences", x => x.Iconference_Id);
                });

            migrationBuilder.CreateTable(
                name: "PRD_Directives",
                columns: table => new
                {
                    Idirective_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iauthor = table.Column<int>(type: "int", nullable: false),
                    Ico_Author_1 = table.Column<int>(type: "int", nullable: false),
                    Ico_Author_2 = table.Column<int>(type: "int", nullable: false),
                    Iassigned_Staff = table.Column<int>(type: "int", nullable: false),
                    Ctext = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cstatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bimage = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRD_Directives", x => x.Idirective_Id);
                });

            migrationBuilder.CreateTable(
                name: "PRD_Files",
                columns: table => new
                {
                    Ifile_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iconference_Id = table.Column<int>(type: "int", nullable: false),
                    Bfile = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRD_Files", x => x.Ifile_Id);
                });

            migrationBuilder.CreateTable(
                name: "PRD_Message_Groups",
                columns: table => new
                {
                    Igroup_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iuser_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRD_Message_Groups", x => x.Igroup_Id);
                });

            migrationBuilder.CreateTable(
                name: "PRD_Messages",
                columns: table => new
                {
                    Imessage_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iauthor = table.Column<int>(type: "int", nullable: false),
                    Igroup_Id = table.Column<int>(type: "int", nullable: false),
                    Ctext = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ttimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRD_Messages", x => x.Imessage_Id);
                });

            migrationBuilder.CreateTable(
                name: "PRD_News",
                columns: table => new
                {
                    Inews_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iconference_Id = table.Column<int>(type: "int", nullable: false),
                    Ctext = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRD_News", x => x.Inews_Id);
                });

            migrationBuilder.CreateTable(
                name: "PRD_Users",
                columns: table => new
                {
                    Iuser_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cusername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaccountType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRD_Users", x => x.Iuser_id);
                });

            migrationBuilder.CreateTable(
                name: "STG_Conferences",
                columns: table => new
                {
                    Iconference_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iprimary_Admin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STG_Conferences", x => x.Iconference_Id);
                });

            migrationBuilder.CreateTable(
                name: "STG_Directives",
                columns: table => new
                {
                    Idirective_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iauthor = table.Column<int>(type: "int", nullable: false),
                    Ico_Author_1 = table.Column<int>(type: "int", nullable: false),
                    Ico_Author_2 = table.Column<int>(type: "int", nullable: false),
                    Iassigned_Staff = table.Column<int>(type: "int", nullable: false),
                    Ctext = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cstatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bimage = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STG_Directives", x => x.Idirective_Id);
                });

            migrationBuilder.CreateTable(
                name: "STG_Files",
                columns: table => new
                {
                    Ifile_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iconference_Id = table.Column<int>(type: "int", nullable: false),
                    Bfile = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STG_Files", x => x.Ifile_Id);
                });

            migrationBuilder.CreateTable(
                name: "STG_Message_Groups",
                columns: table => new
                {
                    Igroup_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iuser_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STG_Message_Groups", x => x.Igroup_Id);
                });

            migrationBuilder.CreateTable(
                name: "STG_Messages",
                columns: table => new
                {
                    Imessage_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iauthor = table.Column<int>(type: "int", nullable: false),
                    Igroup_Id = table.Column<int>(type: "int", nullable: false),
                    Ctext = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ttimestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STG_Messages", x => x.Imessage_Id);
                });

            migrationBuilder.CreateTable(
                name: "STG_News",
                columns: table => new
                {
                    Inews_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iconference_Id = table.Column<int>(type: "int", nullable: false),
                    Ctext = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STG_News", x => x.Inews_Id);
                });

            migrationBuilder.CreateTable(
                name: "STG_Users",
                columns: table => new
                {
                    Iuser_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cusername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaccountType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STG_Users", x => x.Iuser_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRD_Conferences");

            migrationBuilder.DropTable(
                name: "PRD_Directives");

            migrationBuilder.DropTable(
                name: "PRD_Files");

            migrationBuilder.DropTable(
                name: "PRD_Message_Groups");

            migrationBuilder.DropTable(
                name: "PRD_Messages");

            migrationBuilder.DropTable(
                name: "PRD_News");

            migrationBuilder.DropTable(
                name: "PRD_Users");

            migrationBuilder.DropTable(
                name: "STG_Conferences");

            migrationBuilder.DropTable(
                name: "STG_Directives");

            migrationBuilder.DropTable(
                name: "STG_Files");

            migrationBuilder.DropTable(
                name: "STG_Message_Groups");

            migrationBuilder.DropTable(
                name: "STG_Messages");

            migrationBuilder.DropTable(
                name: "STG_News");

            migrationBuilder.DropTable(
                name: "STG_Users");
        }
    }
}
