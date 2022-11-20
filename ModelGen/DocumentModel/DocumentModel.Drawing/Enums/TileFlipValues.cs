namespace DocumentModel.Drawing;

/// <summary>
/// Tile Flip Mode
/// </summary>
public enum TileFlipValues
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
