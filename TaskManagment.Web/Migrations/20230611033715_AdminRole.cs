using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagment.Web.Migrations
{
    /// <inheritdoc />
    public partial class AdminRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"if not exists(select id from AspNetRoles where Id = 'ebc70731-447f-4252-8953-56f6eb9ba85f')
BEGIN
Insert AspNetRoles (Id, [Name], [NormalizedName])
Values ('ebc70731-447f-4252-8953-56f6eb9ba85f', 'admin', 'ADMIN')
END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles where Id = 'ebc70731-447f-4252-8953-56f6eb9ba85f'");
        }
    }
}
