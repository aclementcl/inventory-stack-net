using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CambiotablaStorage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "642bc544-a3dc-4ce9-9035-31477cec55bd");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "ac21668e-e650-4eca-a884-a4ee273b8fa9");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "e677bbe8-44ed-49e2-a89a-c6b30872ca57");

            migrationBuilder.AddColumn<string>(
                name: "WarehouseId",
                table: "Storages",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "StorageId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "2497d98b-4027-42da-a98d-8aee9b2860c0", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "StorageId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "48fa2fd0-20e7-4322-a1fb-70b6fa522ea4", null, "Calle 7 con 24", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "StorageId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "b6aced6c-b6df-4a8c-9795-d53dc2167d03", null, "Calle 6 con 25", "Bodega Sur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "2497d98b-4027-42da-a98d-8aee9b2860c0");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "48fa2fd0-20e7-4322-a1fb-70b6fa522ea4");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "b6aced6c-b6df-4a8c-9795-d53dc2167d03");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Storages");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "StorageId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "e677bbe8-44ed-49e2-a89a-c6b30872ca57", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "StorageId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "642bc544-a3dc-4ce9-9035-31477cec55bd", null, "Calle 7 con 24", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "StorageId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "ac21668e-e650-4eca-a884-a4ee273b8fa9", null, "Calle 6 con 25", "Bodega Sur" });
        }
    }
}
