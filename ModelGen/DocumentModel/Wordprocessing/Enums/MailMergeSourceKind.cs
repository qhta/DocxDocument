namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MailMergeSourceValues enumeration.
/// </summary>
public enum MailMergeSourceKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;database&quot;.
  /// </summary>
  Database,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;addressBook&quot;.
  /// </summary>
  AddressBook,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;document1&quot;.
  /// </summary>
  Document1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;document2&quot;.
  /// </summary>
  Document2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;text&quot;.
  /// </summary>
  Text,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;email&quot;.
  /// </summary>
  Email,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;native&quot;.
  /// </summary>
  Native,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;legacy&quot;.
  /// </summary>
  Legacy,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;master&quot;.
  /// </summary>
  Master,
  
}
