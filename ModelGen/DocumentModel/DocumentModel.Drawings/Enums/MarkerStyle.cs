namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MarkerStyle enumeration.
/// </summary>
public enum MarkerStyle
{
  /// <summary>
  /// circle.
  /// </summary>
  [XmlEnum("circle")]
  Circle,
  
  /// <summary>
  /// dash.
  /// </summary>
  [XmlEnum("dash")]
  Dash,
  
  /// <summary>
  /// diamond.
  /// </summary>
  [XmlEnum("diamond")]
  Diamond,
  
  /// <summary>
  /// dot.
  /// </summary>
  [XmlEnum("dot")]
  Dot,
  
  /// <summary>
  /// plus.
  /// </summary>
  [XmlEnum("plus")]
  Plus,
  
  /// <summary>
  /// square.
  /// </summary>
  [XmlEnum("square")]
  Square,
  
  /// <summary>
  /// star.
  /// </summary>
  [XmlEnum("star")]
  Star,
  
  /// <summary>
  /// triangle.
  /// </summary>
  [XmlEnum("triangle")]
  Triangle,
  
  /// <summary>
  /// x.
  /// </summary>
  [XmlEnum("x")]
  X,
  
}
