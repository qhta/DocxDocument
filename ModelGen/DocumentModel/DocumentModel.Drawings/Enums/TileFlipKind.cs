namespace DocumentModel.Drawings;

/// <summary>
/// Tile Flip Mode
/// </summary>
public enum TileFlipKind
{
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Horizontal.
  /// </summary>
  [XmlEnum("x")]
  Horizontal,
  
  /// <summary>
  /// Vertical.
  /// </summary>
  [XmlEnum("y")]
  Vertical,
  
  /// <summary>
  /// Horizontal and Vertical.
  /// </summary>
  [XmlEnum("xy")]
  HorizontalAndVertical,
  
}
