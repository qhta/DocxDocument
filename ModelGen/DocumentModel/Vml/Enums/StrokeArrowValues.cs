namespace DXV;


/// <summary>
///   Stroke Arrowhead Type
/// </summary>
public enum StrokeArrowValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;block&quot;.
  /// </summary>
  [EnumString("block")]
  Block,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;classic&quot;.
  /// </summary>
  [EnumString("classic")]
  Classic,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;oval&quot;.
  /// </summary>
  [EnumString("oval")]
  Oval,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;diamond&quot;.
  /// </summary>
  [EnumString("diamond")]
  Diamond,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;open&quot;.
  /// </summary>
  [EnumString("open")]
  Open,
  
}
