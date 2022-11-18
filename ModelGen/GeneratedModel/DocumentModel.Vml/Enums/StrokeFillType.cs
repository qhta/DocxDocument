namespace DocumentModel.Vml;

/// <summary>
/// Defines the StrokeFillTypeValues enumeration.
/// </summary>
public enum StrokeFillType
{
  /// <summary>
  /// solid.
  /// </summary>
  [XmlEnum("solid")]
  Solid,
  
  /// <summary>
  /// tile.
  /// </summary>
  [XmlEnum("tile")]
  Tile,
  
  /// <summary>
  /// pattern.
  /// </summary>
  [XmlEnum("pattern")]
  Pattern,
  
  /// <summary>
  /// frame.
  /// </summary>
  [XmlEnum("frame")]
  Frame,
  
}
