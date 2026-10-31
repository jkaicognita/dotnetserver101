using System;
using Oracle.ManagedDataAccess.Client;

namespace ProviderConfig;

public class ProviderDbConfig
{
	private string _oraconstring;
	private string _pgconstring;
	private string _mssqlconstring;
	private string _uname;
	private string _upwd;
	private string _datasource;
	private string _tnsadmindirectory;

	private string _dbtype;

	public string OraConString
	{
		get{ return _oraconstring;}
		set{ _oraconstring = value;}

	}

	public string PgConString
	{
		get{return _pgconstring;}
		set{_pgconstring = value;}

	}

	public string MsSqlConString
	{
		get{return _mssqlconstring;}
		set{_mssqlconstring = value;}

	}

	public string Uname
	{
		get{return _uname;}
		set{_uname = value;}
	}

	public string Upwd
	{
		get{return _upwd;}
		set{_upwd = value;}
	}

	public string Datasource
	{
		get{return _datasource;}
		set{_datasource=value;}
	}

	public string TnsAdminDirectory
	{
		get{return _tnsadmindirectory;}
		set{_tnsadmindirectory = value;}
	}

	public string Dbtype
	{
		get{return _dbtype;}
		set{_dbtype = "ORACLE";}
	}
	public ProviderDbConfig()
	{
		this.TnsAdminDirectory = @"./DAL/ORA/TnsAdmin";
		OracleConfiguration.TnsAdmin = this.TnsAdminDirectory;
		OracleConfiguration.WalletLocation = OracleConfiguration.TnsAdmin;

	}

	public ProviderDbConfig(string constring, string dbtype, string dbid)
	{
		switch(dbid)
		{
			case "101":
			this.TnsAdminDirectory = @"/home/opc/dev/dotnetserver101/ProviderConfig/DAL/ORA/TnsAdmin101";	
			OracleConfiguration.TnsAdmin = this.TnsAdminDirectory;
			OracleConfiguration.WalletLocation = OracleConfiguration.TnsAdmin;
			break;	
			
			case "102":
			this.TnsAdminDirectory = @"/home/opc/dev/dotnetserver101/ProviderConfig/DAL/ORA/TnsAdmin";
			OracleConfiguration.TnsAdmin = this.TnsAdminDirectory;
			OracleConfiguration.WalletLocation = OracleConfiguration.TnsAdmin;
			break;

		}
		//this.TnsAdminDirectory = @"/home/opc/dev/dotnetserver101/ProviderConfig/DAL/ORA/TnsAdmin";
                
                

		using (OracleConnection con = new OracleConnection(constring))
		{
			using(OracleCommand cmd = con.CreateCommand())
			{

				try
				{
					con.Open();
					Console.WriteLine("Connection is Open");
					Console.WriteLine();
					cmd.CommandText = "select * from dual";
					OracleDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						Console.WriteLine(reader.GetString(0));
					}
						
				}	
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}

			}



		}

	}


}
