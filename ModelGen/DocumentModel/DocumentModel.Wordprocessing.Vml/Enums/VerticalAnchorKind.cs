namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Vertical Anchor Type
/// </summary>
public enum VerticalAnchorKind
{
  /// <summary>
  /// Margin.
  /// </summary>
  [XmlEnum("margin")]
  Margin,
  
  /// <summary>
  /// Page.
  /// </summary>
  [XmlEnum("page")]
  Page,
  
  /// <summary>
  /// Text.
  /// </summary>
  [XmlEnum("text")]
  Text,
  
}
