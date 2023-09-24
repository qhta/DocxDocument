namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MailMergeDataValues enumeration.
/// </summary>
public enum MailMergeDataKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textFile&quot;.
  /// </summary>
  [EnumString("textFile")]
  TextFile,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;database&quot;.
  /// </summary>
  [EnumString("database")]
  Database,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;spreadsheet&quot;.
  /// </summary>
  [EnumString("spreadsheet")]
  Spreadsheet,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;query&quot;.
  /// </summary>
  [EnumString("query")]
  Query,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;odbc&quot;.
  /// </summary>
  [EnumString("odbc")]
  Odbc,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;native&quot;.
  /// </summary>
  [EnumString("native")]
  Native,
  
}
