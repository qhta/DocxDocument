namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MailMergeOdsoFieldValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.MailMergeOdsoFieldValues))]
public enum MailMergeOdsoFieldKind
{
  /// <summary>
  ///   IField Not Mapped.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeOdsoFieldValues.Null))]
  Null,
  /// <summary>
  ///   IField Mapping to Data Source IColumn.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MailMergeOdsoFieldValues.DbColumn))]
  DbColumn
}