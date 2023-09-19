namespace DXW;


/// <summary>
///   Defines the HorizontalAnchorValues enumeration.
/// </summary>
public enum HorizontalAnchorValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;text&quot;.
  /// </summary>
  [EnumString("text")]
  Text,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;margin&quot;.
  /// </summary>
  [EnumString("margin")]
  Margin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;page&quot;.
  /// </summary>
  [EnumString("page")]
  Page,
  
}
