using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Races_IrkId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Weapons_SilahId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "SilahId",
                table: "Players",
                newName: "WeaponId");

            migrationBuilder.RenameColumn(
                name: "IrkId",
                table: "Players",
                newName: "RaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_SilahId",
                table: "Players",
                newName: "IX_Players_WeaponId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_IrkId",
                table: "Players",
                newName: "IX_Players_RaceId");

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "ID", "Health", "Name", "Skill" },
                values: new object[,]
                {
                    { 1, 100, "Hunter", "Hunting" },
                    { 2, 100, "Mage", "Spell" },
                    { 3, 100, "Rogue", "Stab" },
                    { 4, 100, "Warrior", "Slash" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "ID", "Energy", "Intelligence", "Name" },
                values: new object[,]
                {
                    { 1, 175, 75, "Dwarf" },
                    { 2, 150, 250, "Elf" },
                    { 3, 150, 150, "Human" },
                    { 4, 250, 20, "Orc" }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "ID", "Damage", "Name" },
                values: new object[,]
                {
                    { 1, 10, "Staff" },
                    { 2, 8, "Axe" },
                    { 3, 4, "Dagger" },
                    { 4, 2, "Cloak" },
                    { 5, 9, "Bow" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Races_RaceId",
                table: "Players",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Weapons_WeaponId",
                table: "Players",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Races_RaceId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Weapons_WeaponId",
                table: "Players");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "WeaponId",
                table: "Players",
                newName: "SilahId");

            migrationBuilder.RenameColumn(
                name: "RaceId",
                table: "Players",
                newName: "IrkId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_WeaponId",
                table: "Players",
                newName: "IX_Players_SilahId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_RaceId",
                table: "Players",
                newName: "IX_Players_IrkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Races_IrkId",
                table: "Players",
                column: "IrkId",
                principalTable: "Races",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Weapons_SilahId",
                table: "Players",
                column: "SilahId",
                principalTable: "Weapons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
