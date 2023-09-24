namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MailMergeOdsoFieldValues enumeration.
/// </summary>
public enum MailMergeOdsoFieldKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;null&quot;.
  /// </summary>
  [EnumString("null")]
  Null,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dbColumn&quot;.
  /// </summary>
  [EnumString("dbColumn")]
  DbColumn,
  
}
