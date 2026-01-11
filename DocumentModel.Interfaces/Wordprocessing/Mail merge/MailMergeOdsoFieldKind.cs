namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MailMergeOdsoFieldValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeOdsoFieldKind
{
  /// <summary>
  ///   Field Not Mapped.
  /// </summary>
  Null,
  /// <summary>
  ///   Field Mapping to Data Source IColumn.
  /// </summary>
  DbColumn
}