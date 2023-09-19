namespace DXW;


/// <summary>
///   Defines the MailMergeSourceValues enumeration.
/// </summary>
public enum MailMergeSourceValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;database&quot;.
  /// </summary>
  [EnumString("database")]
  Database,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;addressBook&quot;.
  /// </summary>
  [EnumString("addressBook")]
  AddressBook,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;document1&quot;.
  /// </summary>
  [EnumString("document1")]
  Document1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;document2&quot;.
  /// </summary>
  [EnumString("document2")]
  Document2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;text&quot;.
  /// </summary>
  [EnumString("text")]
  Text,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;email&quot;.
  /// </summary>
  [EnumString("email")]
  Email,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;native&quot;.
  /// </summary>
  [EnumString("native")]
  Native,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;legacy&quot;.
  /// </summary>
  [EnumString("legacy")]
  Legacy,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;master&quot;.
  /// </summary>
  [EnumString("master")]
  Master,
  
}
