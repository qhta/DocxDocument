namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MailMergeOdsoFieldValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum MailMergeOdsoFieldKind
{
  /// <summary>
  ///   Field Not Mapped.
  /// </summary>
  Null,

  /// <summary>
  ///   Field Mapping to Data Source Column.
  /// </summary>
  DbColumn
}