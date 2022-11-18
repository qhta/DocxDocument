namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Diagram Direction Definition
/// </summary>
public enum Direction
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
