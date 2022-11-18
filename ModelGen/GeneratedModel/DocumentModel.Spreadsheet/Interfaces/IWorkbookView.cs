namespace DocumentModel.Spreadsheet;

/// <summary>
/// Workbook View.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public interface IWorkbookView // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Visibility
  /// </summary>
  public Visibility? Visibility { get ; set; }
  
  /// <summary>
  /// Minimized
  /// </summary>
  public bool? Minimized { get ; set; }
  
  /// <summary>
  /// Show Horizontal Scroll
  /// </summary>
  public bool? ShowHorizontalScroll { get ; set; }
  
  /// <summary>
  /// Show Vertical Scroll
  /// </summary>
  public bool? ShowVerticalScroll { get ; set; }
  
  /// <summary>
  /// Show Sheet Tabs
  /// </summary>
  public bool? ShowSheetTabs { get ; set; }
  
  /// <summary>
  /// Upper Left Corner (X Coordinate)
  /// </summary>
  public int? XWindow { get ; set; }
  
  /// <summary>
  /// Upper Left Corner (Y Coordinate)
  /// </summary>
  public int? YWindow { get ; set; }
  
  /// <summary>
  /// Window Width
  /// </summary>
  public uint? WindowWidth { get ; set; }
  
  /// <summary>
  /// Window Height
  /// </summary>
  public uint? WindowHeight { get ; set; }
  
  /// <summary>
  /// Sheet Tab Ratio
  /// </summary>
  public uint? TabRatio { get ; set; }
  
  /// <summary>
  /// First Sheet
  /// </summary>
  public uint? FirstSheet { get ; set; }
  
  /// <summary>
  /// Active Sheet Index
  /// </summary>
  public uint? ActiveTab { get ; set; }
  
  /// <summary>
  /// AutoFilter Date Grouping
  /// </summary>
  public bool? AutoFilterDateGrouping { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
