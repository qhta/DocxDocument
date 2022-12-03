namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Defines the SizeRelativeVerticallyValues enumeration.
/// </summary>
public enum SizeRelativeVerticallyKind
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
  /// topMargin.
  /// </summary>
  [XmlEnum("topMargin")]
  TopMargin,
  
  /// <summary>
  /// bottomMargin.
  /// </summary>
  [XmlEnum("bottomMargin")]
  BottomMargin,
  
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
