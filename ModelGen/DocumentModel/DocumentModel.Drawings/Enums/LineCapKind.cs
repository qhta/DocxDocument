namespace DocumentModel.Drawings;

/// <summary>
/// End Line Cap
/// </summary>
public enum LineCapKind
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
