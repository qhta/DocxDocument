namespace DocumentModel.Spreadsheet;

/// <summary>
/// Chart Sheet View.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public interface IChartSheetView // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Sheet Tab Selected
  /// </summary>
  public bool? TabSelected { get ; set; }
  
  /// <summary>
  /// Window Zoom Scale
  /// </summary>
  public uint? ZoomScale { get ; set; }
  
  /// <summary>
  /// Workbook View Id
  /// </summary>
  public uint? WorkbookViewId { get ; set; }
  
  /// <summary>
  /// Zoom To Fit
  /// </summary>
  public bool? ZoomToFit { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
