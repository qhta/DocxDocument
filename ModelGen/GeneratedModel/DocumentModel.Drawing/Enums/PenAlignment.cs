namespace DocumentModel.Drawing;

/// <summary>
/// Alignment Type
/// </summary>
public enum PenAlignment
{
  /// <summary>
  /// Center Alignment.
  /// </summary>
  [XmlEnum("ctr")]
  Center,
  
  /// <summary>
  /// Inset Alignment.
  /// </summary>
  [XmlEnum("in")]
  Insert,
  
}
