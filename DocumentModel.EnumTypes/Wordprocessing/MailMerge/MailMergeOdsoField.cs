namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MailMergeOdsoFieldValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.MailMergeOdsoFieldValues))]
public enum MailMergeOdsoField
{
  /// <summary>
  ///   Field Not Mapped.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeOdsoFieldValues.Null))]
  Null,
  /// <summary>
  ///   Field Mapping to Data Source IColumn.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeOdsoFieldValues.DbColumn))]
  DbColumn
}