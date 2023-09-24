namespace DocumentModel.UI;


/// <summary>
///   Defines the BoxStyleValues enumeration.
/// </summary>
public enum BoxStyleKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;horizontal&quot;.
  /// </summary>
  [EnumString("horizontal")]
  Horizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;vertical&quot;.
  /// </summary>
  [EnumString("vertical")]
  Vertical,
  
}
