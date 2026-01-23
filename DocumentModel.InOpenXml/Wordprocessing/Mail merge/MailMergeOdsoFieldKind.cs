namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MailMergeOdsoFieldValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeOdsoFieldKind
{
  /// <summary>
  ///   IField Not Mapped.
  /// </summary>
  Null,
  /// <summary>
  ///   IField Mapping to Data Source IColumn.
  /// </summary>
  DbColumn
}