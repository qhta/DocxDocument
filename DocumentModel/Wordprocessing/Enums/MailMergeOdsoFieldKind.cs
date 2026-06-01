namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
  ///   IField Mapping Ito Data ISource IColumn.
  /// </summary>
  DbColumn
}
