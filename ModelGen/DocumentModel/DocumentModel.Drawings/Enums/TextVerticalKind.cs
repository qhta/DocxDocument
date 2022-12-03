namespace DocumentModel.Drawings;

/// <summary>
/// Vertical Text Types
/// </summary>
public enum TextVerticalKind
{
  /// <summary>
  /// Vertical Text Type Enum ( Horizontal ).
  /// </summary>
  [XmlEnum("horz")]
  Horizontal,
  
  /// <summary>
  /// Vertical Text Type Enum ( Vertical ).
  /// </summary>
  [XmlEnum("vert")]
  Vertical,
  
  /// <summary>
  /// Vertical Text Type Enum ( Vertical 270 ).
  /// </summary>
  [XmlEnum("vert270")]
  Vertical270,
  
  /// <summary>
  /// Vertical Text Type Enum ( WordArt Vertical ).
  /// </summary>
  [XmlEnum("wordArtVert")]
  WordArtVertical,
  
  /// <summary>
  /// Vertical Text Type Enum ( East Asian Vertical ).
  /// </summary>
  [XmlEnum("eaVert")]
  EastAsianVetical,
  
  /// <summary>
  /// Vertical Text Type Enum ( Mongolian Vertical ).
  /// </summary>
  [XmlEnum("mongolianVert")]
  MongolianVertical,
  
  /// <summary>
  /// Vertical WordArt Right to Left.
  /// </summary>
  [XmlEnum("wordArtVertRtl")]
  WordArtLeftToRight,
  
}
