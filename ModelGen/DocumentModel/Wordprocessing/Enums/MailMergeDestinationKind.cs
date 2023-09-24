namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MailMergeDestinationValues enumeration.
/// </summary>
public enum MailMergeDestinationKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;newDocument&quot;.
  /// </summary>
  [EnumString("newDocument")]
  NewDocument,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;printer&quot;.
  /// </summary>
  [EnumString("printer")]
  Printer,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;email&quot;.
  /// </summary>
  [EnumString("email")]
  Email,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;fax&quot;.
  /// </summary>
  [EnumString("fax")]
  Fax,
  
}
