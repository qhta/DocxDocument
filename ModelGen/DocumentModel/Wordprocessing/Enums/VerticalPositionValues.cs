namespace DXW;


/// <summary>
///   Defines the VerticalPositionValues enumeration.
/// </summary>
public enum VerticalPositionValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;baseline&quot;.
  /// </summary>
  [EnumString("baseline")]
  Baseline,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;superscript&quot;.
  /// </summary>
  [EnumString("superscript")]
  Superscript,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;subscript&quot;.
  /// </summary>
  [EnumString("subscript")]
  Subscript,
  
}
