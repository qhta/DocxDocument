namespace DocumentModel.Spreadsheet;

/// <summary>
/// Worksheet View.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPane))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotSelection))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISelection))]
public interface ISheetView // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Window Protection
  /// </summary>
  public bool? WindowProtection { get ; set; }
  
  /// <summary>
  /// Show Formulas
  /// </summary>
  public bool? ShowFormulas { get ; set; }
  
  /// <summary>
  /// Show Grid Lines
  /// </summary>
  public bool? ShowGridLines { get ; set; }
  
  /// <summary>
  /// Show Headers
  /// </summary>
  public bool? ShowRowColHeaders { get ; set; }
  
  /// <summary>
  /// Show Zero Values
  /// </summary>
  public bool? ShowZeros { get ; set; }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  public bool? RightToLeft { get ; set; }
  
  /// <summary>
  /// Sheet Tab Selected
  /// </summary>
  public bool? TabSelected { get ; set; }
  
  /// <summary>
  /// Show Ruler
  /// </summary>
  public bool? ShowRuler { get ; set; }
  
  /// <summary>
  /// Show Outline Symbols
  /// </summary>
  public bool? ShowOutlineSymbols { get ; set; }
  
  /// <summary>
  /// Default Grid Color
  /// </summary>
  public bool? DefaultGridColor { get ; set; }
  
  /// <summary>
  /// Show White Space
  /// </summary>
  public bool? ShowWhiteSpace { get ; set; }
  
  /// <summary>
  /// View Type
  /// </summary>
  public SheetViewValues? View { get ; set; }
  
  /// <summary>
  /// Top Left Visible Cell
  /// </summary>
  public string? TopLeftCell { get ; set; }
  
  /// <summary>
  /// Color Id
  /// </summary>
  public uint? ColorId { get ; set; }
  
  /// <summary>
  /// Zoom Scale
  /// </summary>
  public uint? ZoomScale { get ; set; }
  
  /// <summary>
  /// Zoom Scale Normal View
  /// </summary>
  public uint? ZoomScaleNormal { get ; set; }
  
  /// <summary>
  /// Zoom Scale Page Break Preview
  /// </summary>
  public uint? ZoomScaleSheetLayoutView { get ; set; }
  
  /// <summary>
  /// Zoom Scale Page Layout View
  /// </summary>
  public uint? ZoomScalePageLayoutView { get ; set; }
  
  /// <summary>
  /// Workbook View Index
  /// </summary>
  public uint? WorkbookViewId { get ; set; }
  
  /// <summary>
  /// View Pane.
  /// </summary>
  public IPane? Pane { get ; set; }
  
}
