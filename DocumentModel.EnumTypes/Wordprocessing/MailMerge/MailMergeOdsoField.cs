namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MailMergeOdsoFieldValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues))]
public enum MailMergeOdsoField
{
  /// <summary>
  ///   Field Not Mapped.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues.Null))]
  Null,
  /// <summary>
  ///   Field Mapping to Data Source IColumn.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues.DbColumn))]
  DbColumn
}