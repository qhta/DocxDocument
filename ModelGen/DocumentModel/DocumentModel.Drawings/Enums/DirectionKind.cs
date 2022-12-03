namespace DocumentModel.Drawings;

/// <summary>
/// Diagram Direction Definition
/// </summary>
public enum DirectionKind
{
  /// <summary>
  /// Normal Direction.
  /// </summary>
  [XmlEnum("norm")]
  Normal,
  
  /// <summary>
  /// Reversed Direction.
  /// </summary>
  [XmlEnum("rev")]
  Reversed,
  
}
