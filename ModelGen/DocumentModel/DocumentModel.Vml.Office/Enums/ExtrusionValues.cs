namespace DocumentModel.Vml.Office;

/// <summary>
/// Extrusion Type
/// </summary>
public enum ExtrusionValues
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
