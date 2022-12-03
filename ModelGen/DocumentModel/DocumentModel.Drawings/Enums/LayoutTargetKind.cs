namespace DocumentModel.Drawings;

/// <summary>
/// Layout Target
/// </summary>
public enum LayoutTargetKind
{
  /// <summary>
  /// Inner.
  /// </summary>
  [XmlEnum("inner")]
  Inner,
  
  /// <summary>
  /// Outer.
  /// </summary>
  [XmlEnum("outer")]
  Outer,
  
}
