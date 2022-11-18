namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AbsolutePositionTabPositioningBaseValues enumeration.
/// </summary>
public enum AbsolutePositionTabPositioningBase
{
  /// <summary>
  /// Relative To Text Margins.
  /// </summary>
  [XmlEnum("margin")]
  Margin,
  
  /// <summary>
  /// Relative To Indents.
  /// </summary>
  [XmlEnum("indent")]
  Indent,
  
}
