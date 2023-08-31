using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace T_G.ECommerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("11d6f34c-52c5-408c-8d83-e93a51548025"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3650), "Cosmetic", null },
                    { new Guid("12108f44-2aa8-4a5d-bf2d-dc91e552e017"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3637), "Laptop", null },
                    { new Guid("19cdfaee-e22f-48a1-b172-b9a9f92e9214"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3649), "Shoe", null },
                    { new Guid("252feae8-fa30-47b7-9554-91eb2025eebb"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3651), "Furniture", null },
                    { new Guid("8d1f9698-77a6-4e0d-b399-384f6fbb736a"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3648), "Book", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Name", "Price", "Rating", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0456675b-eca9-4d43-b130-f28fc466d78e"), new Guid("12108f44-2aa8-4a5d-bf2d-dc91e552e017"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3738), "Laptop description", "Laptop 5", 11999f, 4.3m, 350, null },
                    { new Guid("050461bd-313e-433e-9aec-74dc87b2fd8c"), new Guid("19cdfaee-e22f-48a1-b172-b9a9f92e9214"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3778), "Shoe description", "Shoe 5", 250f, 4.3m, 350, null },
                    { new Guid("0a8772cc-a650-4ce8-a674-5d3b312a2bc4"), new Guid("12108f44-2aa8-4a5d-bf2d-dc91e552e017"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3745), "Laptop description", "Laptop 9", 15999f, 4.7m, 940, null },
                    { new Guid("185e63b6-863d-46e4-8302-36e3246a3a03"), new Guid("252feae8-fa30-47b7-9554-91eb2025eebb"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3849), "Furniture description", "Furniture 9", 3500f, 4.7m, 940, null },
                    { new Guid("203a23f0-42e9-4399-9015-c87cd71ca3d2"), new Guid("8d1f9698-77a6-4e0d-b399-384f6fbb736a"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3755), "Book description", "Book 3", 70f, 4.6m, 300, null },
                    { new Guid("2245af99-67f5-4054-a953-945efbf1c023"), new Guid("8d1f9698-77a6-4e0d-b399-384f6fbb736a"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3769), "Book description", "Book 10", 199f, 4.2m, 130, null },
                    { new Guid("2b6ed6b5-b0ea-465e-b506-fa5564881847"), new Guid("252feae8-fa30-47b7-9554-91eb2025eebb"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3851), "Furniture description", "Furniture 10", 1950f, 4.2m, 130, null },
                    { new Guid("2c9d379e-b50f-4c3b-8259-105cf29ac623"), new Guid("11d6f34c-52c5-408c-8d83-e93a51548025"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3800), "Cosmetic description", "Cosmetic 6", 200f, 4.5m, 570, null },
                    { new Guid("2dd779b5-5dfb-4039-8464-f67c747348ed"), new Guid("8d1f9698-77a6-4e0d-b399-384f6fbb736a"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3753), "Book description", "Book 2", 60f, 4.3m, 400, null },
                    { new Guid("31f9820b-af16-48ed-b494-237a29b6fa30"), new Guid("252feae8-fa30-47b7-9554-91eb2025eebb"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3814), "Furniture description", "Furniture 3", 800f, 4.6m, 300, null },
                    { new Guid("32b5a580-fb3d-4212-a0d3-af54a69434a2"), new Guid("19cdfaee-e22f-48a1-b172-b9a9f92e9214"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3788), "Shoe description", "Shoe 10", 1990f, 4.2m, 130, null },
                    { new Guid("34b47478-7a2a-4a88-99a2-472afb148106"), new Guid("19cdfaee-e22f-48a1-b172-b9a9f92e9214"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3783), "Shoe description", "Shoe 7", 1300f, 2.8m, 670, null },
                    { new Guid("37c154ac-8946-4888-b9e3-672f3047967b"), new Guid("11d6f34c-52c5-408c-8d83-e93a51548025"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3807), "Cosmetic description", "Cosmetic 10", 190f, 4.2m, 130, null },
                    { new Guid("3cc91dea-5506-4946-9341-8e11d6bd0b5c"), new Guid("8d1f9698-77a6-4e0d-b399-384f6fbb736a"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3762), "Book description", "Book 7", 130f, 2.8m, 670, null },
                    { new Guid("3ccf2335-5937-40f1-8c5a-ce4fc7cced77"), new Guid("11d6f34c-52c5-408c-8d83-e93a51548025"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3790), "Cosmetic description", "Cosmetic 1", 100f, 4.2m, 500, null },
                    { new Guid("436df773-59d4-49ef-ba77-822d4bf55aff"), new Guid("252feae8-fa30-47b7-9554-91eb2025eebb"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3811), "Furniture description", "Furniture 2", 700f, 4.3m, 400, null },
                    { new Guid("46ac94bb-390f-4be6-8a0a-2d94bf9e68c1"), new Guid("12108f44-2aa8-4a5d-bf2d-dc91e552e017"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3743), "Laptop description", "Laptop 8", 14999f, 3.6m, 580, null },
                    { new Guid("4a2a7ac3-b72b-4aff-8bb4-6dd566af554b"), new Guid("19cdfaee-e22f-48a1-b172-b9a9f92e9214"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3779), "Shoe description", "Shoe 6", 200f, 4.5m, 570, null },
                    { new Guid("4e21c3f3-6087-4077-8a4e-2552a10302bb"), new Guid("11d6f34c-52c5-408c-8d83-e93a51548025"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3794), "Cosmetic description", "Cosmetic 3", 80f, 4.6m, 300, null },
                    { new Guid("5e0925b9-f20f-45a6-b713-94ac0043e2ba"), new Guid("252feae8-fa30-47b7-9554-91eb2025eebb"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3818), "Furniture description", "Furniture 5", 1550f, 4.3m, 350, null },
                    { new Guid("7417ca5c-604f-4c49-ba89-814e6c9b6f7b"), new Guid("19cdfaee-e22f-48a1-b172-b9a9f92e9214"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3786), "Shoe description", "Shoe 9", 3000f, 4.7m, 940, null },
                    { new Guid("780bee16-aa3e-452d-9589-d4b2e24ea6eb"), new Guid("8d1f9698-77a6-4e0d-b399-384f6fbb736a"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3764), "Book description", "Book 8", 250f, 3.6m, 580, null },
                    { new Guid("796a535e-e944-46d5-ba7a-6b478a0ca66d"), new Guid("252feae8-fa30-47b7-9554-91eb2025eebb"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3809), "Furniture description", "Furniture 1", 1000f, 4.2m, 500, null },
                    { new Guid("80fbe55b-1d37-4c40-9c8e-864ab537dd5b"), new Guid("12108f44-2aa8-4a5d-bf2d-dc91e552e017"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3747), "Laptop description", "Laptop 10", 16999f, 4.2m, 130, null },
                    { new Guid("855184b0-27d0-4b0f-a4e2-64954956b687"), new Guid("12108f44-2aa8-4a5d-bf2d-dc91e552e017"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3736), "Laptop description", "Laptop 4", 10999f, 3.7m, 250, null },
                    { new Guid("8e391020-67c4-4710-821e-6ba0adca8403"), new Guid("8d1f9698-77a6-4e0d-b399-384f6fbb736a"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3758), "Book description", "Book 5", 25f, 4.3m, 350, null },
                    { new Guid("8f49d0f9-b3c9-4677-8293-85b7ee960db8"), new Guid("12108f44-2aa8-4a5d-bf2d-dc91e552e017"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3725), "Laptop description", "Laptop 2", 8999f, 4.3m, 400, null },
                    { new Guid("9b0cd04e-b3b9-45c7-bd16-1e4537baae56"), new Guid("8d1f9698-77a6-4e0d-b399-384f6fbb736a"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3751), "Book description", "Book 1", 50f, 4.2m, 500, null },
                    { new Guid("9b48190a-846f-4622-bd2a-21aff3ebcdd4"), new Guid("11d6f34c-52c5-408c-8d83-e93a51548025"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3804), "Cosmetic description", "Cosmetic 8", 200f, 3.6m, 580, null },
                    { new Guid("9c8544d0-7e83-40c3-b38a-ce9dd0b9a1f6"), new Guid("252feae8-fa30-47b7-9554-91eb2025eebb"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3819), "Furniture description", "Furniture 6", 2050f, 4.5m, 570, null },
                    { new Guid("a2870186-5d8d-4f11-9b76-b72a41c77b36"), new Guid("12108f44-2aa8-4a5d-bf2d-dc91e552e017"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3734), "Laptop description", "Laptop 3", 9999f, 4.6m, 300, null },
                    { new Guid("a74a3b1b-2734-47b1-ad19-8f2e7cd95543"), new Guid("19cdfaee-e22f-48a1-b172-b9a9f92e9214"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3773), "Shoe description", "Shoe 2", 600f, 4.3m, 400, null },
                    { new Guid("adcf151c-c6bf-47bb-a764-7072099249e8"), new Guid("11d6f34c-52c5-408c-8d83-e93a51548025"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3802), "Cosmetic description", "Cosmetic 7", 300f, 2.8m, 670, null },
                    { new Guid("b9aa926d-617e-4c68-b192-fd511afa23c9"), new Guid("19cdfaee-e22f-48a1-b172-b9a9f92e9214"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3771), "Shoe description", "Shoe 1", 500f, 4.2m, 500, null },
                    { new Guid("bc48897f-a496-4e30-aff3-64107534dbf6"), new Guid("19cdfaee-e22f-48a1-b172-b9a9f92e9214"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3774), "Shoe description", "Shoe 3", 700f, 4.6m, 300, null },
                    { new Guid("c16ac1bf-3a29-445e-ba89-7d8d0d77d71e"), new Guid("12108f44-2aa8-4a5d-bf2d-dc91e552e017"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3739), "Laptop description", "Laptop 6", 12999f, 4.5m, 570, null },
                    { new Guid("c337d5c5-748d-496d-93c1-8bcdf8c7d840"), new Guid("252feae8-fa30-47b7-9554-91eb2025eebb"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3847), "Furniture description", "Furniture 8", 2500f, 3.6m, 580, null },
                    { new Guid("c4cada5f-b05a-4f7c-9f01-07726651b133"), new Guid("11d6f34c-52c5-408c-8d83-e93a51548025"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3795), "Cosmetic description", "Cosmetic 4", 40f, 3.7m, 250, null },
                    { new Guid("ca69a7a6-0856-466b-8f97-0e9d5c81353d"), new Guid("12108f44-2aa8-4a5d-bf2d-dc91e552e017"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3717), "Laptop description", "Laptop 1", 7999f, 4.2m, 500, null },
                    { new Guid("ca74ed7b-808b-456f-b71b-711e1ae2ed60"), new Guid("8d1f9698-77a6-4e0d-b399-384f6fbb736a"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3767), "Book description", "Book 9", 300f, 4.7m, 940, null },
                    { new Guid("ccfae51d-5bbf-4980-9b95-4f9950a8f985"), new Guid("252feae8-fa30-47b7-9554-91eb2025eebb"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3816), "Furniture description", "Furniture 4", 450f, 3.7m, 250, null },
                    { new Guid("dd5c5239-b441-48fc-8cb5-c9757cabdb79"), new Guid("11d6f34c-52c5-408c-8d83-e93a51548025"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3806), "Cosmetic description", "Cosmetic 9", 300f, 4.7m, 940, null },
                    { new Guid("dd693237-743f-416a-8dba-fe3a370bbeeb"), new Guid("19cdfaee-e22f-48a1-b172-b9a9f92e9214"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3776), "Shoe description", "Shoe 4", 750f, 3.7m, 250, null },
                    { new Guid("deeca117-c11f-421c-8a2e-6d1706231c6b"), new Guid("19cdfaee-e22f-48a1-b172-b9a9f92e9214"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3785), "Shoe description", "Shoe 8", 2500f, 3.6m, 580, null },
                    { new Guid("df65edfe-7b2c-49ae-bb3d-cbc6de5f150a"), new Guid("11d6f34c-52c5-408c-8d83-e93a51548025"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3792), "Cosmetic description", "Cosmetic 2", 70f, 4.3m, 400, null },
                    { new Guid("e9438e5f-8569-4a82-bb2c-5013965b365e"), new Guid("11d6f34c-52c5-408c-8d83-e93a51548025"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3799), "Cosmetic description", "Cosmetic 5", 150f, 4.3m, 350, null },
                    { new Guid("ec7f7a3e-07dc-4fb7-a124-4a69ed47b350"), new Guid("252feae8-fa30-47b7-9554-91eb2025eebb"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3845), "Furniture description", "Furniture 7", 3500f, 2.8m, 670, null },
                    { new Guid("f1350811-8d93-47e4-b040-8e24c51ab964"), new Guid("8d1f9698-77a6-4e0d-b399-384f6fbb736a"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3757), "Book description", "Book 4", 75f, 3.7m, 250, null },
                    { new Guid("f34af61d-56d8-4f42-bd1a-7e2c5832a961"), new Guid("12108f44-2aa8-4a5d-bf2d-dc91e552e017"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3741), "Laptop description", "Laptop 7", 13999f, 2.8m, 670, null },
                    { new Guid("fd26fc86-872b-47c8-b6e5-5a9270196428"), new Guid("8d1f9698-77a6-4e0d-b399-384f6fbb736a"), new DateTime(2023, 8, 31, 14, 27, 53, 981, DateTimeKind.Local).AddTicks(3760), "Book description", "Book 6", 20f, 4.5m, 570, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
