namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Defines the SizeRelativeHorizontallyValues enumeration.
/// </summary>
public enum SizeRelativeHorizontallyKind
{
  /// <summary>
  /// margin.
  /// </summary>
  [XmlEnum("margin")]
  Margin,
  
  /// <summary>
  /// page.
  /// </summary>
  [XmlEnum("page")]
  Page,
  
  /// <summary>
  /// leftMargin.
  /// </summary>
  [XmlEnum("leftMargin")]
  LeftMargin,
  
  /// <summary>
  /// rightMargin.
  /// </summary>
  [XmlEnum("rightMargin")]
  RightMargin,
  
  /// <summary>
  /// insideMargin.
  /// </summary>
  [XmlEnum("insideMargin")]
  InsideMargin,
  
  /// <summary>
  /// outsideMargin.
  /// </summary>
  [XmlEnum("outsideMargin")]
  OutsideMargin,
  
}
