namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MailMergeDataValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.MailMergeDataValues))]
public enum MailMergeData
{
  /// <summary>
  ///   Text File Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDataValues.TextFile))]
  TextFile,
  /// <summary>
  ///   Database Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDataValues.Database))]
  Database,
  /// <summary>
  ///   Spreadsheet Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDataValues.Spreadsheet))]
  Spreadsheet,
  /// <summary>
  ///   Query Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDataValues.Query))]
  Query,
  /// <summary>
  ///   Open Database Connectivity Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDataValues.Odbc))]
  Odbc,
  /// <summary>
  ///   Office Data Source Object Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeDataValues.Native))]
  Native
}