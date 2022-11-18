namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the FeatureType enumeration.
/// </summary>
public enum FeatureType
{
  /// <summary>
  /// dataValidation.
  /// </summary>
  [XmlEnum("dataValidation")]
  DataValidation,
  
  /// <summary>
  /// hyperlink.
  /// </summary>
  [XmlEnum("hyperlink")]
  Hyperlink,
  
  /// <summary>
  /// rowColVisualOps.
  /// </summary>
  [XmlEnum("rowColVisualOps")]
  RowColVisualOps,
  
  /// <summary>
  /// freezePanes.
  /// </summary>
  [XmlEnum("freezePanes")]
  FreezePanes,
  
  /// <summary>
  /// sparklines.
  /// </summary>
  [XmlEnum("sparklines")]
  Sparklines,
  
  /// <summary>
  /// hideUnhideSheet.
  /// </summary>
  [XmlEnum("hideUnhideSheet")]
  HideUnhideSheet,
  
  /// <summary>
  /// showGridlinesHeadings.
  /// </summary>
  [XmlEnum("showGridlinesHeadings")]
  ShowGridlinesHeadings,
  
  /// <summary>
  /// comment.
  /// </summary>
  [XmlEnum("comment")]
  Comment,
  
  /// <summary>
  /// outlines.
  /// </summary>
  [XmlEnum("outlines")]
  Outlines,
  
  /// <summary>
  /// drawingElement.
  /// </summary>
  [XmlEnum("drawingElement")]
  DrawingElement,
  
  /// <summary>
  /// autoFilter.
  /// </summary>
  [XmlEnum("autoFilter")]
  AutoFilter,
  
  /// <summary>
  /// pivotTable.
  /// </summary>
  [XmlEnum("pivotTable")]
  PivotTable,
  
  /// <summary>
  /// future.
  /// </summary>
  [XmlEnum("future")]
  Future,
  
}
