using System.Data;
using Microsoft.Data.SqlClient;

namespace PMG;

public class SqlRecordSet 
{
	#region Fields and Properties
	private readonly SqlDataReader _sqlReader;
	#endregion

	#region Methods
	#region Constructors
	public SqlRecordSet(SqlDataReader reader)
	{
		//Reader = reader;
		_sqlReader = reader;
	}
	#endregion

	//public override TBaseRecordset Clone()
	//{
	//	return (SqlRecordSet)MemberwiseClone();
	//}

	//public override Int32[] ColumnNameToIndices(String name)
	//{
	//	return _sqlReader.GetColumnSchema().Where(c => c.ColumnName == name).Select(c => c.ColumnOrdinal ?? -1).Where(i => i >= 0).Ordered();
	//}

	//public override Boolean GetBool(String columnName) { return !_sqlReader.IsDBNull(columnName) && _sqlReader.GetBoolean(columnName); }
	//public override Char GetChar(String columnName)
	//{
	//	//TEMP
	//	Object temp = _sqlReader.GetValue(columnName);
	//	return temp.ToString()[0];
	//	//return _sqlReader.GetChar(columnName); 
	//}
	//public override List<ColumnInfo> GetColumnInfo() { return new List<ColumnInfo>(); }
	//public override DateTime GetDate(String columnName) { return _sqlReader.GetDateTime(columnName); }
	//public override DateTime GetDate(Int32 columnNumber) { return _sqlReader.GetDateTime(columnNumber); }
	//public override DateTime GetDate(String columnName, Boolean useCurrentDateIfInvalid)
	//{
	//	try
	//	{
	//		Boolean isNull = _sqlReader.IsDBNull(columnName);
	//		if (isNull)
	//		{ throw new NullReferenceException($"{columnName} was null."); }
	//		_ = Int32.TryParse(_sqlReader.GetValue(columnName).ToString(), out Int32 dateInt32);
	//		return dateInt32 == 0 ? DateTime.Now : dateInt32.ToDateTime();
			

	//	}
	//	catch (InvalidCastException)
	//	{
	//		Object bad = _sqlReader.GetValue(columnName);
	//		return DateTime.Now;
	//	}
	//}
	//public override Decimal GetDecimal(String columnName) { return _sqlReader.IsDBNull(columnName) ? 0 : _sqlReader.GetDecimal(columnName); }
	//public override Double GetDouble(String columnName) { return _sqlReader.IsDBNull(columnName) ? 0 : _sqlReader.GetDouble(columnName); }
	//public override Int32 GetInteger(String columnName) { return _sqlReader.IsDBNull(columnName) ? 0 : _sqlReader.GetInt32(columnName); }
	//public override Int32 GetLong(String columnName) { return _sqlReader.IsDBNull(columnName) ? 0 : _sqlReader.GetInt32(columnName); }
	//public override Int32 GetRecordCount() { return 1; }  //{ return _sqlReader.RecordsAffected; }
	//public override String GetString(String columnName) { return _sqlReader.GetString(columnName).TrimEnd(); }
	//public override Object GetValue(String columnName) { return _sqlReader.GetValue(columnName); }
	//public override DataTable GetSchemaTable() { return _sqlReader.GetSchemaTable(); }
	#endregion
}