namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MailMergeDataValues enumeration.
/// </summary>
public enum MailMergeDataKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textFile&quot;.
  /// </summary>
  TextFile,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;database&quot;.
  /// </summary>
  Database,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;spreadsheet&quot;.
  /// </summary>
  Spreadsheet,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;query&quot;.
  /// </summary>
  Query,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;odbc&quot;.
  /// </summary>
  Odbc,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;native&quot;.
  /// </summary>
  Native,
  
}
