namespace DocumentModel.Drawing;

/// <summary>
/// End Line Cap
/// </summary>
public enum LineCapValues
{
  /// <summary>
  /// Round Line Cap.
  /// </summary>
  [XmlEnum("rnd")]
  Round,
  
  /// <summary>
  /// Square Line Cap.
  /// </summary>
  [XmlEnum("sq")]
  Square,
  
  /// <summary>
  /// Flat Line Cap.
  /// </summary>
  [XmlEnum("flat")]
  Flat,
  
}
