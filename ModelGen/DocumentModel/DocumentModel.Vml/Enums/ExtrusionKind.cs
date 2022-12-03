namespace DocumentModel.Vml;

/// <summary>
/// Extrusion Type
/// </summary>
public enum ExtrusionKind
{
  /// <summary>
  /// Perspective Projection.
  /// </summary>
  [XmlEnum("perspective")]
  Perspective,
  
  /// <summary>
  /// Parallel Projection.
  /// </summary>
  [XmlEnum("parallel")]
  Parallel,
  
}
