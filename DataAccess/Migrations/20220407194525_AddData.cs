using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "09348cdb-cd87-44c3-a325-c7ac9d9867a4");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "431d9c09-f2a9-4b7b-ba4a-dd45c24b4886");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "63558ebc-1b96-4bd7-9bfa-38a6bd70a351");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "StorageId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "431d9c09-f2a9-4b7b-ba4a-dd45c24b4886", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "StorageId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "63558ebc-1b96-4bd7-9bfa-38a6bd70a351", null, "Calle 7 con 24", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "StorageId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "09348cdb-cd87-44c3-a325-c7ac9d9867a4", null, "Calle 6 con 25", "Bodega Sur" });
        }
    }
}
