namespace DocumentModel.Drawings;


/// <summary>
///   Vertical Text Types
/// </summary>
public enum TextVerticalKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;horz&quot;.
  /// </summary>
  Horizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;vert&quot;.
  /// </summary>
  Vertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;vert270&quot;.
  /// </summary>
  Vertical270,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wordArtVert&quot;.
  /// </summary>
  WordArtVertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eaVert&quot;.
  /// </summary>
  EastAsianVetical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mongolianVert&quot;.
  /// </summary>
  MongolianVertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wordArtVertRtl&quot;.
  /// </summary>
  WordArtLeftToRight,
  
}
