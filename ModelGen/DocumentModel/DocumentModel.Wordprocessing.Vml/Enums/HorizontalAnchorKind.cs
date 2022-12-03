namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Horizontal Anchor Type
/// </summary>
public enum HorizontalAnchorKind
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
