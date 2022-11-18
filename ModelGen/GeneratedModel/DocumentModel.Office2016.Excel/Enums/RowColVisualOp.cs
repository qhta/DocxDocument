namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RowColVisualOp enumeration.
/// </summary>
public enum RowColVisualOp
{
  /// <summary>
  /// hide.
  /// </summary>
  [XmlEnum("hide")]
  Hide,
  
  /// <summary>
  /// unhide.
  /// </summary>
  [XmlEnum("unhide")]
  Unhide,
  
  /// <summary>
  /// resize.
  /// </summary>
  [XmlEnum("resize")]
  Resize,
  
  /// <summary>
  /// autosize.
  /// </summary>
  [XmlEnum("autosize")]
  Autosize,
  
}
