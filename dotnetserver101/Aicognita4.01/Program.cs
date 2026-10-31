// See https://aka.ms/new-console-template for more information
using ProviderConfig;
using System;
using System.IO;
using System.Text.Json;
//string username;

//-----------------------------------------GET PARAMETERS FOR CONNECTION FROM SECURE FILE----------------------------------
const string ConfigPath = "/home/opc/.config/aicognita/aicognita.json";

public sealed class OracleConfig
{
    public string UserName { get; set; } = "";
    public string Password { get; set; } = "";
    public string DataSource { get; set; } = "";
}

//-----------------------------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("User name:");
var username = Console.ReadLine();
Console.WriteLine("Password");
var upwd = Console.ReadLine();
//////////////////////////////////////////////////
//string username = "ADMIN";
//string upwd = "Stromboli*88*";
string oradatasource = "oradb102_high";

string constring = "User Id=" + username +";" + "Password=" + upwd +";" +"Data Source=" + oradatasource + ";";
//ProviderDbConfig Config = new ProviderDbConfig();



ProviderDbConfig Config = new ProviderDbConfig(constring, "ORACLE", "102");

//Console.WriteLine(constring);
//Console.WriteLine(Config.TnsAdminDirectory);
Console.WriteLine("Datase is ACCESSIBLE");










