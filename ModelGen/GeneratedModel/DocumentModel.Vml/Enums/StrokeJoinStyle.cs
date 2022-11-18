namespace DocumentModel.Vml;

/// <summary>
/// Line Join Type
/// </summary>
public enum StrokeJoinStyle
{
  /// <summary>
  /// Round Joint.
  /// </summary>
  [XmlEnum("round")]
  Round,
  
  /// <summary>
  /// Bevel Joint.
  /// </summary>
  [XmlEnum("bevel")]
  Bevel,
  
  /// <summary>
  /// Miter Joint.
  /// </summary>
  [XmlEnum("miter")]
  Miter,
  
}
