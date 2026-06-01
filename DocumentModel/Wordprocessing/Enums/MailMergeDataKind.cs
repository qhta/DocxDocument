namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the MailMergeDataValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeDataKind
{
  /// <summary>
  ///   Text File Data ISource.
  /// </summary>
  TextFile,

  /// <summary>
  ///   Database Data ISource.
  /// </summary>
  Database,

  /// <summary>
  ///   Spreadsheet Data ISource.
  /// </summary>
  Spreadsheet,

  /// <summary>
  ///   Query Data ISource.
  /// </summary>
  Query,

  /// <summary>
  ///   Open Database Connectivity Data ISource.
  /// </summary>
  Odbc,

  /// <summary>
  ///   Office Data ISource Object Data ISource.
  /// </summary>
  Native
}
