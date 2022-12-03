namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HorizontalAnchorValues enumeration.
/// </summary>
public enum HorizontalAnchorKind
{
  /// <summary>
  /// Relative to Text Extents.
  /// </summary>
  [XmlEnum("text")]
  Text,
  
  /// <summary>
  /// Relative To Margin.
  /// </summary>
  [XmlEnum("margin")]
  Margin,
  
  /// <summary>
  /// Relative to Page.
  /// </summary>
  [XmlEnum("page")]
  Page,
  
}
