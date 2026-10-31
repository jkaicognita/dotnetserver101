// See https://aka.ms/new-console-template for more information
using System;
using ProviderConfig;

Console.WriteLine("User Name");
var username = Console.ReadLine();

Console.WriteLine("Password");
var upwd = Console.ReadLine();

string oradatasource = "oradb101_high";

string constring = "user Id=" + username + ";" + "Password=" + upwd + ";" + "Data Source=" + oradatasource + ";";

ProviderDbConfig Config = new ProviderDbConfig(constring, "ORACLE", "101");

Console.WriteLine("Database is ACCESSIBLE");
