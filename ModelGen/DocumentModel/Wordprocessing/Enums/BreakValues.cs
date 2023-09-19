namespace DXW;


/// <summary>
///   Defines the BreakValues enumeration.
/// </summary>
public enum BreakValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;page&quot;.
  /// </summary>
  [EnumString("page")]
  Page,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;column&quot;.
  /// </summary>
  [EnumString("column")]
  Column,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textWrapping&quot;.
  /// </summary>
  [EnumString("textWrapping")]
  TextWrapping,
  
}
