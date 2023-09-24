namespace DocumentModel.Vml;


/// <summary>
///   Defines the StrokeFillTypeValues enumeration.
/// </summary>
public enum StrokeFillTypeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;solid&quot;.
  /// </summary>
  [EnumString("solid")]
  Solid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tile&quot;.
  /// </summary>
  [EnumString("tile")]
  Tile,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pattern&quot;.
  /// </summary>
  [EnumString("pattern")]
  Pattern,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;frame&quot;.
  /// </summary>
  [EnumString("frame")]
  Frame,
  
}
