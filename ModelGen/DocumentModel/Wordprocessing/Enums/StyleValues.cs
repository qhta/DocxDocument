namespace DXW;


/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
public enum StyleValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;paragraph&quot;.
  /// </summary>
  [EnumString("paragraph")]
  Paragraph,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;character&quot;.
  /// </summary>
  [EnumString("character")]
  Character,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;table&quot;.
  /// </summary>
  [EnumString("table")]
  Table,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;numbering&quot;.
  /// </summary>
  [EnumString("numbering")]
  Numbering,
  
}
