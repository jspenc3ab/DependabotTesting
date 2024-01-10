using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PMG
{
	public enum RS_FILTER_PARAMS
	{
		eRSFilterNone = 0,
		eRSFilterString = 1,
		eRSFilterParams = 2
	}

	public struct ColumnInfo
	{
		public String Name;
		public Int32 Index;
	}

	public class DataTypeMisMatchException : Exception
	{
		#region Fields and Properties
		#endregion

		#region Methods
		#region Constructors
		public DataTypeMisMatchException(String pMessage) : base(pMessage) { }
		#endregion
		#endregion

	}

	public class TBaseRecordset
	{
		#region Fields and Properties
		protected Boolean NextResultAvailable { get; set; } = false;
		protected Boolean ResultsAvailable { get; set; } = false;

		public String Name { get; set; }
		public IDataReader Reader { get; set; }


		#endregion

		#region Methods
		#region Constructors
		#endregion
		public virtual void BeginProcessing() { }

		public virtual TBaseRecordset Clone() { throw new NotImplementedException(); }
		public virtual void Close() 
		{ 
			Reader.Close(); 
		}

		public virtual void Disconnect() { }
		
		/// <summary>
		/// Gets the sorted indices of all columns that share the given name.
		/// todo ggallant Fix the offending SPs to return unique column names so this method can be deprecated and the affected fields can be indexed normally by name.
		/// </summary>
		public virtual Int32[] ColumnNameToIndices(String name) { throw new NotImplementedException(); }

		public virtual Boolean GetBool(String columnName) { throw new NotImplementedException(); }
		public virtual Boolean GetBool(Int32 columnNumber, String columnName) { throw new Exception("Indexing by column number not available in this version of ADORecordSet."); }
		public virtual Char GetChar(String columnName) { throw new NotImplementedException(); }
		public virtual Char GetChar(Int32 columnNumber, String columnName) { throw new Exception("Indexing by column number not available in this version of ADORecordSet."); }
		public virtual List<ColumnInfo> GetColumnInfo() { return new List<ColumnInfo>(); }
		public virtual DateTime GetDate(String columnName) { throw new NotImplementedException(); }
		public virtual DateTime GetDate(Int32 columnNumber) { throw new NotImplementedException(); }
		public virtual DateTime GetDate(Int32 columnNumber, String columnName, Boolean useCurrenctDateIfInvalid) { throw new Exception("Indexing by column number not available in this version of ADORecordSet."); }
		public virtual DateTime GetDate(String columnName, Boolean useCurrenctDateIfInvalid) { throw new NotImplementedException(); }
		public virtual Decimal GetDecimal(String columnName) { throw new NotImplementedException(); }
		public virtual Double GetDouble(String columnName) { throw new NotImplementedException(); }
		public virtual Double GetDouble(Int32 columnNumber, String columnName) { throw new Exception("Indexing by column number not available in this version of ADORecordSet."); }
		public virtual Int32 GetInteger(String columnName) { throw new NotImplementedException(); }
		public virtual Int32 GetInteger(Int32 columnNumber, String columnName) { throw new Exception("Indexing by column number not available in this version of ADORecordSet."); }
		public virtual Int32 GetLong(String columnName) { throw new NotImplementedException(); }
		public virtual Int32 GetLong(Int32 columnNumber, String columnName) { throw new Exception("Indexing by column number not available in this version of ADORecordSet."); }
		public virtual Int32 GetRecordCount() { return 1; }
		public virtual DataTable GetSchemaTable() { throw new NotImplementedException(); }
		public virtual String GetString(String columnName) { throw new NotImplementedException(); }
		public virtual String GetString(Int32 columnNumber, String columnName) { throw new Exception("Indexing by column number not available in this version of ADORecordSet."); }
		public virtual Object GetValue(String columnName) { throw new NotImplementedException(); }



		public virtual Boolean IsEOF() { return !ResultsAvailable; }
		public virtual Boolean IsFirstRecord() { return false; }
		public virtual void MoveNext() { ResultsAvailable = Reader.Read(); }
		public virtual void NextRecordset() { NextResultAvailable = Reader.NextResult(); }

		public virtual void SaveToFile(String filePath) { }

		public virtual void SetFilter(String filterString) { }
		public virtual void SetFilter(TParameters parameters) { }
		public virtual RS_FILTER_PARAMS SupportsFilterString() { return RS_FILTER_PARAMS.eRSFilterNone; }

		public virtual Boolean TryGetLong(String columnName, out Int32 value) 
		{
			value = 0;
			return false; 
		}
		public virtual Boolean TryGetString(String columnName, out String value)
		{
			value = String.Empty;
			return false;
		}


		#endregion
	}
}
