namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MailMergeDataValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeDataKind
{
  /// <summary>
  ///   Text File Data Source.
  /// </summary>
  TextFile,

  /// <summary>
  ///   Database Data Source.
  /// </summary>
  Database,

  /// <summary>
  ///   Spreadsheet Data Source.
  /// </summary>
  Spreadsheet,

  /// <summary>
  ///   Query Data Source.
  /// </summary>
  Query,

  /// <summary>
  ///   Open Database Connectivity Data Source.
  /// </summary>
  Odbc,

  /// <summary>
  ///   Office Data Source Object Data Source.
  /// </summary>
  Native
}