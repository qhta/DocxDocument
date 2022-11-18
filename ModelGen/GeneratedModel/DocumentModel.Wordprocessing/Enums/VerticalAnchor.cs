namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalAnchorValues enumeration.
/// </summary>
public enum VerticalAnchor
{
  /// <summary>
  /// Relative To Vertical Text Extents.
  /// </summary>
  [XmlEnum("text")]
  Text,
  
  /// <summary>
  /// Relative To Margin.
  /// </summary>
  [XmlEnum("margin")]
  Margin,
  
  /// <summary>
  /// Relative To Page.
  /// </summary>
  [XmlEnum("page")]
  Page,
  
}
