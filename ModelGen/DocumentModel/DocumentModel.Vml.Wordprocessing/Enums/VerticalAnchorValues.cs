namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Vertical Anchor Type
/// </summary>
public enum VerticalAnchorValues
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
