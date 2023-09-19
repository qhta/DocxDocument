namespace DXW;


/// <summary>
///   Defines the DocumentTypeValues enumeration.
/// </summary>
public enum DocumentTypeValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;notSpecified&quot;.
  /// </summary>
  [EnumString("notSpecified")]
  NotSpecified,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;letter&quot;.
  /// </summary>
  [EnumString("letter")]
  Letter,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eMail&quot;.
  /// </summary>
  [EnumString("eMail")]
  Email,
  
}
