namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet View Type
/// </summary>
public enum SheetView
{
  /// <summary>
  /// Normal View.
  /// </summary>
  [XmlEnum("normal")]
  Normal,
  
  /// <summary>
  /// Page Break Preview.
  /// </summary>
  [XmlEnum("pageBreakPreview")]
  PageBreakPreview,
  
  /// <summary>
  /// Page Layout View.
  /// </summary>
  [XmlEnum("pageLayout")]
  PageLayout,
  
}
