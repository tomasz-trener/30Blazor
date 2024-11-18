using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "4135803517878", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 829.69211569320976, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Wooden Chair" },
                    { 2, "6803006536917", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 136.24926863901749, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Metal Car" },
                    { 3, "6170030750344", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 419.39507149923367, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Wooden Fish" },
                    { 4, "4125416944444", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 131.31670311853136, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Concrete Bacon" },
                    { 5, "0970650659319", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 214.24055093724306, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Rubber Keyboard" },
                    { 6, "6529290068629", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 708.6934623945009, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Cotton Computer" },
                    { 7, "1800862881385", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 181.36082924313882, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Cotton Keyboard" },
                    { 8, "9592797096348", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 557.22589721168663, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Practical Steel Gloves" },
                    { 9, "2236899047712", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 820.03939995311168, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Rubber Bike" },
                    { 10, "4528392089848", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 684.27186477522923, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Soft Gloves" },
                    { 11, "8079060231985", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 594.96452395523181, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Rubber Computer" },
                    { 12, "0669820509058", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 647.12403275544011, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Fresh Car" },
                    { 13, "9237492608327", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 624.90486521735079, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Wooden Soap" },
                    { 14, "5446087306966", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 860.2957212493269, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Steel Pizza" },
                    { 15, "9898673383732", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 149.8611582894163, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Frozen Pants" },
                    { 16, "6179936432293", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 41.4314823357535, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Fresh Bike" },
                    { 17, "1019870314994", "The Football Is Good For Training And Recreational Purposes", 890.5148672757274, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awesome Fresh Sausages" },
                    { 18, "3281043334131", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 431.1791396155856, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Soft Fish" },
                    { 19, "7220837679658", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 121.94656162287414, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Granite Cheese" },
                    { 20, "5767158553899", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 121.02393029864129, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Granite Towels" },
                    { 21, "9403581525787", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 891.07206650174783, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Frozen Mouse" },
                    { 22, "9014664420860", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 150.44004214435819, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Frozen Towels" },
                    { 23, "5067095180173", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 475.13188163290357, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Frozen Shoes" },
                    { 24, "0104385927294", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 763.56302413882827, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awesome Cotton Gloves" },
                    { 25, "4504815286377", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 478.91523904302869, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Practical Rubber Bike" },
                    { 26, "9339120881215", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 74.051527644531575, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade Metal Towels" },
                    { 27, "9823104151222", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 84.032778956942622, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Practical Cotton Salad" },
                    { 28, "6814229609203", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 357.52829439822972, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Steel Chicken" },
                    { 29, "7797738860763", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 643.07406103241919, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Concrete Table" },
                    { 30, "7006653700208", "The Football Is Good For Training And Recreational Purposes", 63.614898659575211, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Wooden Soap" },
                    { 31, "2966952662100", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 867.34741706137891, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Frozen Pizza" },
                    { 32, "4430026962673", "The Football Is Good For Training And Recreational Purposes", 322.70866367952368, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Fresh Tuna" },
                    { 33, "8684847902172", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 433.71145619717959, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Steel Sausages" },
                    { 34, "5438269622698", "The Football Is Good For Training And Recreational Purposes", 827.45005094467206, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Concrete Towels" },
                    { 35, "9978695199525", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 338.55159992005281, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Wooden Ball" },
                    { 36, "5456608751199", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 662.42108751433955, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Steel Computer" },
                    { 37, "2579847727442", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 974.5654807722035, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Wooden Pizza" },
                    { 38, "6767398108414", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 467.51950786193811, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Plastic Towels" },
                    { 39, "7537707833332", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 386.02067984920961, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Fresh Tuna" },
                    { 40, "4002869876358", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 473.97394598739874, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Fresh Soap" },
                    { 41, "5047978806475", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 509.88383010955704, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Fresh Bacon" },
                    { 42, "3561884993439", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 583.8249252991867, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Practical Frozen Pizza" },
                    { 43, "3577531489408", "The Football Is Good For Training And Recreational Purposes", 158.36421467939587, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Cotton Towels" },
                    { 44, "5223619893343", "The Football Is Good For Training And Recreational Purposes", 589.19982115048902, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Metal Shoes" },
                    { 45, "5228724708094", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 269.05001498900816, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Concrete Sausages" },
                    { 46, "8327748969799", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 616.70941943522052, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Metal Sausages" },
                    { 47, "1227707662983", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 65.019721532249704, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic Soft Hat" },
                    { 48, "3694884912688", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 184.72559618564586, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Metal Table" },
                    { 49, "5768134111805", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 552.4624730993354, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Wooden Hat" },
                    { 50, "4875337867185", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 884.29157508783578, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Plastic Pants" },
                    { 51, "1603134376585", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 792.91939277105007, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Wooden Table" },
                    { 52, "6649138045336", "The Football Is Good For Training And Recreational Purposes", 66.205732664189171, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Steel Ball" },
                    { 53, "1625252267194", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 491.4547220549801, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Practical Steel Shoes" },
                    { 54, "5828932277193", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 598.82490147921476, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Metal Salad" },
                    { 55, "8524302656618", "The Football Is Good For Training And Recreational Purposes", 350.54359373429025, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Rubber Computer" },
                    { 56, "5616130358024", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 861.54531531946054, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Fresh Table" },
                    { 57, "8311189147519", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 465.46177874107929, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Steel Car" },
                    { 58, "0446721181145", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 380.92345042849121, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic Fresh Fish" },
                    { 59, "0187381575416", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 183.72819443360353, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Granite Towels" },
                    { 60, "9597009936771", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 5.0901571819978564, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Frozen Gloves" },
                    { 61, "8606762106695", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 898.397511797211, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Wooden Chair" },
                    { 62, "5974909801387", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 180.51852417807959, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Concrete Pizza" },
                    { 63, "1723297603295", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 573.80863870857695, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Cotton Shoes" },
                    { 64, "6064851864833", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 41.934165286335237, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Granite Sausages" },
                    { 65, "0198200797681", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 757.79967412296662, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Concrete Mouse" },
                    { 66, "7310210564821", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 471.23339342243662, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Soft Table" },
                    { 67, "4862306797499", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 255.68489719726372, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awesome Steel Computer" },
                    { 68, "4806798265142", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 42.821179837836503, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Metal Table" },
                    { 69, "3552425324652", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 776.80525399316343, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Metal Towels" },
                    { 70, "5275688965520", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 493.66506883532975, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Soft Table" },
                    { 71, "4858055354267", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 858.81639124956746, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Steel Salad" },
                    { 72, "1321676277916", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 882.6857174600874, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Soft Fish" },
                    { 73, "3556572214637", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 116.689460747265, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Cotton Fish" },
                    { 74, "9566718528515", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 716.42358648237939, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Fresh Bacon" },
                    { 75, "3171550953089", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 580.86470317275473, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Wooden Hat" },
                    { 76, "4104646139608", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 962.02758268175069, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Fresh Mouse" },
                    { 77, "4625495718863", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 392.5458063108594, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Plastic Computer" },
                    { 78, "6381770016380", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 877.84281514018903, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Frozen Pants" },
                    { 79, "4504015755840", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 425.69537124070121, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Steel Sausages" },
                    { 80, "6742791423180", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 385.23291431937037, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Steel Gloves" },
                    { 81, "4894623321163", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 984.15386507434482, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Fresh Salad" },
                    { 82, "3291768088387", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 946.98884686734016, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Metal Car" },
                    { 83, "5519051847076", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 953.96033969705934, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade Metal Chips" },
                    { 84, "4618721473056", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 841.90270586260715, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Metal Keyboard" },
                    { 85, "0559378228726", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 298.92139472110262, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Cotton Mouse" },
                    { 86, "2201720521136", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 892.90532059031784, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Wooden Bike" },
                    { 87, "5568193553314", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 664.73058655566103, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Plastic Pizza" },
                    { 88, "2841324405793", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 588.09672927814381, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Concrete Cheese" },
                    { 89, "5610036529731", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 201.07776998313039, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Rubber Sausages" },
                    { 90, "0984231303669", "The Football Is Good For Training And Recreational Purposes", 432.09319924520946, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Fresh Pants" },
                    { 91, "7165157502708", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 718.83903196679387, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Metal Shirt" },
                    { 92, "5907229699099", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 771.37464212690236, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade Metal Shirt" },
                    { 93, "1288931820426", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 616.58239172193328, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Concrete Pants" },
                    { 94, "1310487815660", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 559.67407292997189, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Metal Bike" },
                    { 95, "5148568802539", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 116.65926629475284, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Frozen Pants" },
                    { 96, "0996731077520", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 365.43258493739768, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Plastic Salad" },
                    { 97, "1076573146154", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 248.18219422557493, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic Steel Computer" },
                    { 98, "8395883888350", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 763.69709537909239, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Plastic Cheese" },
                    { 99, "2886526427945", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 375.65533092927905, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Wooden Table" },
                    { 100, "1747214879969", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 347.04380050489857, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Granite Bacon" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
