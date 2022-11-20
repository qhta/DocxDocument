namespace DocumentModel.Spreadsheet;

/// <summary>
/// Pane Types
/// </summary>
public enum PaneValues
{
  /// <summary>
  /// Bottom Right Pane.
  /// </summary>
  [XmlEnum("bottomRight")]
  BottomRight,
  
  /// <summary>
  /// Top Right Pane.
  /// </summary>
  [XmlEnum("topRight")]
  TopRight,
  
  /// <summary>
  /// Bottom Left Pane.
  /// </summary>
  [XmlEnum("bottomLeft")]
  BottomLeft,
  
  /// <summary>
  /// Top Left Pane.
  /// </summary>
  [XmlEnum("topLeft")]
  TopLeft,
  
}
