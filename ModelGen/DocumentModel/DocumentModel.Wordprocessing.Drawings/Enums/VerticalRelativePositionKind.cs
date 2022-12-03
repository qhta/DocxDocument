namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Vertical Relative Positioning
/// </summary>
public enum VerticalRelativePositionKind
{
  /// <summary>
  /// Page Margin.
  /// </summary>
  [XmlEnum("margin")]
  Margin,
  
  /// <summary>
  /// Page Edge.
  /// </summary>
  [XmlEnum("page")]
  Page,
  
  /// <summary>
  /// Paragraph.
  /// </summary>
  [XmlEnum("paragraph")]
  Paragraph,
  
  /// <summary>
  /// Line.
  /// </summary>
  [XmlEnum("line")]
  Line,
  
  /// <summary>
  /// Top Margin.
  /// </summary>
  [XmlEnum("topMargin")]
  TopMargin,
  
  /// <summary>
  /// Bottom Margin.
  /// </summary>
  [XmlEnum("bottomMargin")]
  BottomMargin,
  
  /// <summary>
  /// Inside Margin.
  /// </summary>
  [XmlEnum("insideMargin")]
  InsideMargin,
  
  /// <summary>
  /// Outside Margin.
  /// </summary>
  [XmlEnum("outsideMargin")]
  OutsideMargin,
  
}
