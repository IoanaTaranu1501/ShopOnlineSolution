using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    /// <inheritdoc />
    public partial class NewDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Gel de curatare de la CeraVe pentru tenul sensibil.", "/Images/Beauty/Beauty1.jpg", "CeraVe - Gel de curatare", 40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Crema hidratanta de la CeraVe pentru ten uscat.", "/Images/Beauty/Beauty2.jpg", "CeraVe - Crema hidratanta" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Crema cu factor de protectie 50 de la Avene.", "Avene - SPF", 70m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Spray parfumat de corp de la Victoria Secrets.", "/Images/Beauty/Beauty4.jpg", "Spray Victoria Secrets", 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Crema cu factor de protectie 50 de la SVR.", "/Images/Beauty/Beauty5.jpg", "SVR - SPF", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Casti JBL roz", "/Images/Electronic/Electronics1.jpg", "Casti JBL" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Casti JBL negre", "/Images/Electronic/Electronics2.jpg", "Casti JBL" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Casti JBL mov", "/Images/Electronic/Electronics3.jpg", "Casti JBL" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Aparat profesional Canon", "/Images/Electronic/Electronic4.jpg", "Aparat Canon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Camera de facut poze instant", "/Images/Electronic/Electronic5.jpg", "Instant Camera" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Camera de facut poze instant Canon", "/Images/Electronic/technology6.jpg", "Camera instant Canon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Canapea eleganta roz", "/Images/Furniture/Furniture1.jpg", "Canapea roz" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Canapea sufragerie bej", "/Images/Furniture/Furniture2.jpg", "Canapea bej" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Canapea sufragerie roz", "/Images/Furniture/Furniture3.jpg", "Canapea roz" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Canapea eleganta neagra", "/Images/Furniture/Furniture4.jpg", "Canapea neagra" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Canapea alba pentru hol", "/Images/Furniture/Furniture6.jpg", "Canapea alba" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Canapea albastra pentru hol/sufragerie", "/Images/Furniture/Furniture7.jpg", "Canapea albastra" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Nike shoes roz pentru femei", "/Images/Shoes/Shoes1.jpg", "Nike Adidasi roz" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Nike shoes albi pentru femei", "/Images/Shoes/Shoes2.jpg", "Nike Adidasi albi" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Nike shoes roz inchis pentru femei", "/Images/Shoes/Shoes3.jpg", "Nike Adidasi roz inchis" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Nike pinky shoes pentru femei", "/Images/Shoes/Shoes4.jpg", "Nike Adidasi roz" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Nike shoes albi cu logo verde pentru femei", "/Images/Shoes/Shoes5.jpg", "Nike Adidasi alb si verde" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Nike shoes roz cu portocaliu pentru femei", "/Images/Shoes/Shoes6.jpg", "Nike Adidasi portocalii" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserName",
                value: "Andrei");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserName",
                value: "Ana");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty2.png", "Curology - Skin Care Kit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "A kit provided by Curology, containing skin care products", "Cocooil - Organic Coconut Oil", 20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "A kit provided by Schwarzkopf, containing skin care and hair care products", "/Images/Beauty/Beauty4.png", "Schwarzkopf - Hair Care and Skin Care Kit", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", "Skin Care Kit", 30m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", "Air Pods" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", "On-ear Golden Headphones" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", "On-ear Black Headphones" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronic4.png", "Sennheiser Digital Camera with Tripod" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronic5.png", "Canon Digital Camera" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Gameboy - Provided by Nintendo", "/Images/Electronic/technology6.png", "Nintendo Gameboy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", "Black Leather Office Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", "Pink Leather Office Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", "Lounge Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", "Silver Lounge Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", "Porcelain Table Lamp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Office Table Lamp", "/Images/Furniture/Furniture7.png", "Office Table Lamp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", "Puma Sneakers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", "Colorful Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", "Blue Nike Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", "Colorful Hummel Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", "Red Nike Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", "Birkenstock Sandles" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserName",
                value: "Bob");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserName",
                value: "Sarah");
        }
    }
}
