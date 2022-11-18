namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Horizontal Relative Positioning
/// </summary>
public enum HorizontalRelativePosition
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
  /// Column.
  /// </summary>
  [XmlEnum("column")]
  Column,
  
  /// <summary>
  /// Character.
  /// </summary>
  [XmlEnum("character")]
  Character,
  
  /// <summary>
  /// Left Margin.
  /// </summary>
  [XmlEnum("leftMargin")]
  LeftMargin,
  
  /// <summary>
  /// Right Margin.
  /// </summary>
  [XmlEnum("rightMargin")]
  RightMargin,
  
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
