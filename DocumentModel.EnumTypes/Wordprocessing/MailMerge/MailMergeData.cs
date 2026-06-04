namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MailMergeDataValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues))]
public enum MailMergeData
{
  /// <summary>
  ///   Text File Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues.TextFile))]
  TextFile,
  /// <summary>
  ///   Database Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues.Database))]
  Database,
  /// <summary>
  ///   Spreadsheet Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues.Spreadsheet))]
  Spreadsheet,
  /// <summary>
  ///   Query Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues.Query))]
  Query,
  /// <summary>
  ///   Open Database Connectivity Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues.Odbc))]
  Odbc,
  /// <summary>
  ///   Office Data Source Object Data Source.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues.Native))]
  Native
}