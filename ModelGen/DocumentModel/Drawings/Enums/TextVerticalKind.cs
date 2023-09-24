namespace DocumentModel.Drawings;


/// <summary>
///   Vertical Text Types
/// </summary>
public enum TextVerticalKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;horz&quot;.
  /// </summary>
  [EnumString("horz")]
  Horizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;vert&quot;.
  /// </summary>
  [EnumString("vert")]
  Vertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;vert270&quot;.
  /// </summary>
  [EnumString("vert270")]
  Vertical270,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wordArtVert&quot;.
  /// </summary>
  [EnumString("wordArtVert")]
  WordArtVertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eaVert&quot;.
  /// </summary>
  [EnumString("eaVert")]
  EastAsianVetical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mongolianVert&quot;.
  /// </summary>
  [EnumString("mongolianVert")]
  MongolianVertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wordArtVertRtl&quot;.
  /// </summary>
  [EnumString("wordArtVertRtl")]
  WordArtLeftToRight,
  
}
