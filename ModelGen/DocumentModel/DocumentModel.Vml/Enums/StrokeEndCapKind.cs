namespace DocumentModel.Vml;

/// <summary>
/// Stroke End Cap Type
/// </summary>
public enum StrokeEndCapKind
{
  /// <summary>
  /// Flat End.
  /// </summary>
  [XmlEnum("flat")]
  Flat,
  
  /// <summary>
  /// Square End.
  /// </summary>
  [XmlEnum("square")]
  Square,
  
  /// <summary>
  /// Round End.
  /// </summary>
  [XmlEnum("round")]
  Round,
  
}
