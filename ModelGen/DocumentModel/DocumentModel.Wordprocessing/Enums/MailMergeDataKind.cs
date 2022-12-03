namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MailMergeDataValues enumeration.
/// </summary>
public enum MailMergeDataKind
{
  /// <summary>
  /// Text File Data Source.
  /// </summary>
  [XmlEnum("textFile")]
  TextFile,
  
  /// <summary>
  /// Database Data Source.
  /// </summary>
  [XmlEnum("database")]
  Database,
  
  /// <summary>
  /// Spreadsheet Data Source.
  /// </summary>
  [XmlEnum("spreadsheet")]
  Spreadsheet,
  
  /// <summary>
  /// Query Data Source.
  /// </summary>
  [XmlEnum("query")]
  Query,
  
  /// <summary>
  /// Open Database Connectivity Data Source.
  /// </summary>
  [XmlEnum("odbc")]
  Odbc,
  
  /// <summary>
  /// Office Data Source Object Data Source.
  /// </summary>
  [XmlEnum("native")]
  Native,
  
}
