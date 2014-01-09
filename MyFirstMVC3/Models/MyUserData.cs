using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVC3.Models
{
    public class MyUserRepo
    {
        public static List<MyUser> MyUsers = new List<MyUser>(){

            new MyUser(){ UserID =54498,        Name = "Warrenson",           Address = "address 1",        Town = "town",        County = "county",        Country = "England",        Rating = 8,        DoB = new System.DateTime(1988,11,24), UserName="test"},
            new MyUser(){ UserID =54499,        Name = "Natashason",           Address = "Unit 6",        Town = "Malpas",        County = "Cheshire",        Country = "England",        Rating = 9,        DoB = new System.DateTime(1990,3,4), UserName="admin"},
            new MyUser(){ UserID =54500,        Name = "Johnson",           Address = "Unit H2",        Town = "Cardiff",        County = "South Wales",        Country = "Wales",        Rating = 0,        DoB = new System.DateTime(1987,5,10)},
            new MyUser(){ UserID =54501,        Name = "Jenson",           Address = "65 Archery Grove",        Town = "Southampton",        County = "Hampshire",        Country = "England",        Rating = 1,        DoB = new System.DateTime(1988,3,13)},
            new MyUser(){ UserID =54502,        Name = "Alexson",           Address = "120 Leman Street",        Town = "",        County = "London",        Country = "England",        Rating = 2,        DoB = new System.DateTime(1990,1,22)},
            new MyUser(){ UserID =54503,        Name = "Simonson",           Address = "",        Town = "",        County = "",        Country = "England",        Rating = 3,        DoB = new System.DateTime(1982,3,25)},
            new MyUser(){ UserID =54504,        Name = "Kimson",           Address = "PO Box 662",        Town = "Bournemouth ",        County = "Dorset",        Country = "England",        Rating = 4,        DoB = new System.DateTime(1986,7,18)},
            new MyUser(){ UserID =54505,        Name = "Peterson",           Address = "Unit 19 ",        Town = "Aldershot",        County = "Hampshire",        Country = "England",        Rating = 5,        DoB = new System.DateTime(1987,8,14)},
            new MyUser(){ UserID =54506,        Name = "Mson",           Address = "Ten Acre Farm",        Town = "Ottershaw",        County = "Surrey ",        Country = "England",        Rating = 6,        DoB = new System.DateTime(1984,1,14)},
            new MyUser(){ UserID =54507,        Name = "Julianson",           Address = "Redland Office Centre ",        Town = "Bristol",        County = "Avon",        Country = "England",        Rating = 7,        DoB = new System.DateTime(1990,1,26)},
            new MyUser(){ UserID =54508,        Name = "Andyson",           Address = "Unit 2, Pauls Farm Buildings",        Town = "Hawkhurst",        County = "Kent",        Country = "England",        Rating = 8,        DoB = new System.DateTime(1988,2,19)},
            new MyUser(){ UserID =54509,        Name = "Davidson",           Address = "144a Old South Lambeth Road",        Town = "Vauxhall",        County = "London",        Country = "England",        Rating = 9,        DoB = new System.DateTime(1986,7,20)},
            new MyUser(){ UserID =54510,        Name = "Alanson",           Address = "2 Scotts Way",        Town = "Sevenoaks",        County = "Kent",        Country = "England",        Rating = 0,        DoB = new System.DateTime(1989,10,29)},
            new MyUser(){ UserID =54511,        Name = "Andyson",           Address = "Leisure House",        Town = "Charminster",        County = "Dorset",        Country = "England",        Rating = 1,        DoB = new System.DateTime(1985,5,9)},
            new MyUser(){ UserID =54512,        Name = "Carolynson",           Address = "54 Westminster Drive",        Town = "Doncaster",        County = "South Yorkshire",        Country = "England",        Rating = 2,        DoB = new System.DateTime(1988,10,22)},
            new MyUser(){ UserID =54513,        Name = "ELIASson",           Address = "62-64 Upper Walkway",        Town = "",        County = "London",        Country = "England",        Rating = 3,        DoB = new System.DateTime(1986,11,1)},
            new MyUser(){ UserID =54514,        Name = "Colinson",           Address = "132 Chase Way",        Town = "",        County = "London",        Country = "England",        Rating = 4,        DoB = new System.DateTime(1986,11,29)},
            new MyUser(){ UserID =54515,        Name = "Mattson",           Address = "PO Box 668",        Town = "Cardiff",        County = "South Wales",        Country = "Wales",        Rating = 5,        DoB = new System.DateTime(1986,4,6)},
            new MyUser(){ UserID =54516,        Name = "Paulson",           Address = "P.O Box 167",        Town = "Manchester",        County = "Greater Manchester",        Country = "England",        Rating = 6,        DoB = new System.DateTime(1984,2,2)},
            new MyUser(){ UserID =54517,        Name = "Belindason",           Address = "Ivy House",        Town = "Faringdon",        County = "Oxfordshire",        Country = "England",        Rating = 7,        DoB = new System.DateTime(1989,1,24)},
            new MyUser(){ UserID =54518,        Name = "Richardson",           Address = "Shaw House",        Town = "Naseby",        County = "Northamptonshire",        Country = "England",        Rating = 8,        DoB = new System.DateTime(1986,1,23)},
            new MyUser(){ UserID =54519,        Name = "Hannahson",           Address = "Dyffryn Orion",        Town = "Llandysul",        County = "Carmarthenshire",        Country = "Wales",        Rating = 9,        DoB = new System.DateTime(1986,7,21)},
            new MyUser(){ UserID =54520,        Name = "chrisson",           Address = "Unit 2",        Town = "Machynlleth",        County = "Powys",        Country = "Wales",        Rating = 0,        DoB = new System.DateTime(1985,5,20)},
            new MyUser(){ UserID =54521,        Name = "Alson",           Address = "5 Newlands Close",        Town = "Stone",        County = "Staffordshire",        Country = "England",        Rating = 1,        DoB = new System.DateTime(1986,8,2)},
            new MyUser(){ UserID =54522,        Name = "Francescason",           Address = "unit c, woodside trade centre",        Town = "Eastly",        County = "Hampshire",        Country = "England",        Rating = 2,        DoB = new System.DateTime(1988,6,29)},
            new MyUser(){ UserID =54523,        Name = "Robson",           Address = "263 Abbeydale Road",        Town = "Wembley",        County = "London",        Country = "England",        Rating = 3,        DoB = new System.DateTime(1983,2,21)},
            new MyUser(){ UserID =54524,        Name = "Mauriceson",           Address = "Springvale",        Town = "Southampton",        County = "Hampshire",        Country = "England",        Rating = 4,        DoB = new System.DateTime(1985,3,29)},
            new MyUser(){ UserID =54525,        Name = "Paulson",           Address = "65 - 67 Bute Street",        Town = "Luton",        County = "Bedfordshire",        Country = "England",        Rating = 5,        DoB = new System.DateTime(1990,4,9)},
            new MyUser(){ UserID =54526,        Name = "Ianson",           Address = "9A Bells Road",        Town = "Great Yarmouth",        County = "Norfolk",        Country = "England",        Rating = 6,        DoB = new System.DateTime(1985,10,25)},
            new MyUser(){ UserID =54527,        Name = "Davidson",           Address = "Unit 8",        Town = "Leeds",        County = "West Yorkshire",        Country = "England",        Rating = 7,        DoB = new System.DateTime(1988,1,28)}                                             
        };
    }
}