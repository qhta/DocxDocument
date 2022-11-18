namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MailMergeOdsoFieldValues enumeration.
/// </summary>
public enum MailMergeOdsoField
{
  /// <summary>
  /// Field Not Mapped.
  /// </summary>
  [XmlEnum("null")]
  Null,
  
  /// <summary>
  /// Field Mapping to Data Source Column.
  /// </summary>
  [XmlEnum("dbColumn")]
  DbColumn,
  
}
