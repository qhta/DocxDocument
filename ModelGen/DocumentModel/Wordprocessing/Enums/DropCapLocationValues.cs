namespace DXW;


/// <summary>
///   Defines the DropCapLocationValues enumeration.
/// </summary>
public enum DropCapLocationValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;drop&quot;.
  /// </summary>
  [EnumString("drop")]
  Drop,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;margin&quot;.
  /// </summary>
  [EnumString("margin")]
  Margin,
  
}
