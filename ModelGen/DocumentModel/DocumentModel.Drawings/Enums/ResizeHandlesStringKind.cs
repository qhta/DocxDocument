namespace DocumentModel.Drawings;

/// <summary>
/// Resize Handle
/// </summary>
public enum ResizeHandlesStringKind
{
  /// <summary>
  /// Exact.
  /// </summary>
  [XmlEnum("exact")]
  Exact,
  
  /// <summary>
  /// Relative.
  /// </summary>
  [XmlEnum("rel")]
  Relative,
  
}
