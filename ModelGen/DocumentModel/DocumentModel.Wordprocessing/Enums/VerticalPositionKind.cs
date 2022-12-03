namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalPositionValues enumeration.
/// </summary>
public enum VerticalPositionKind
{
  /// <summary>
  /// Regular Vertical Positioning.
  /// </summary>
  [XmlEnum("baseline")]
  Baseline,
  
  /// <summary>
  /// Superscript.
  /// </summary>
  [XmlEnum("superscript")]
  Superscript,
  
  /// <summary>
  /// Subscript.
  /// </summary>
  [XmlEnum("subscript")]
  Subscript,
  
}
