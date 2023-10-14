namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MailMergeDestinationValues enumeration.
/// </summary>
public enum MailMergeDestinationKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;newDocument&quot;.
  /// </summary>
  NewDocument,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;printer&quot;.
  /// </summary>
  Printer,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;email&quot;.
  /// </summary>
  Email,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;fax&quot;.
  /// </summary>
  Fax,
  
}
