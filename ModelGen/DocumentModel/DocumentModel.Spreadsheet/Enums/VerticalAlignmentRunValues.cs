namespace DocumentModel.Spreadsheet;

/// <summary>
/// Vertical Alignment Run Types
/// </summary>
public enum VerticalAlignmentRunValues
{
  /// <summary>
  /// Baseline.
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
