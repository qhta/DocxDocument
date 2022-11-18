namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Horizontal Anchor Type
/// </summary>
public enum HorizontalAnchor
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
