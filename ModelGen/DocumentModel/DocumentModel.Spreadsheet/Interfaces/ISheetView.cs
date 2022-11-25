namespace DocumentModel.Spreadsheet;

/// <summary>
/// Worksheet View.
/// </summary>
public interface ISheetView // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Window Protection
  /// </summary>
  public System.Boolean? WindowProtection { get ; set; }
  
  /// <summary>
  /// Show Formulas
  /// </summary>
  public System.Boolean? ShowFormulas { get ; set; }
  
  /// <summary>
  /// Show Grid Lines
  /// </summary>
  public System.Boolean? ShowGridLines { get ; set; }
  
  /// <summary>
  /// Show Headers
  /// </summary>
  public System.Boolean? ShowRowColHeaders { get ; set; }
  
  /// <summary>
  /// Show Zero Values
  /// </summary>
  public System.Boolean? ShowZeros { get ; set; }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  public System.Boolean? RightToLeft { get ; set; }
  
  /// <summary>
  /// Sheet Tab Selected
  /// </summary>
  public System.Boolean? TabSelected { get ; set; }
  
  /// <summary>
  /// Show Ruler
  /// </summary>
  public System.Boolean? ShowRuler { get ; set; }
  
  /// <summary>
  /// Show Outline Symbols
  /// </summary>
  public System.Boolean? ShowOutlineSymbols { get ; set; }
  
  /// <summary>
  /// Default Grid Color
  /// </summary>
  public System.Boolean? DefaultGridColor { get ; set; }
  
  /// <summary>
  /// Show White Space
  /// </summary>
  public System.Boolean? ShowWhiteSpace { get ; set; }
  
  /// <summary>
  /// View Type
  /// </summary>
  public DocumentModel.Spreadsheet.SheetViewKind? View { get ; set; }
  
  /// <summary>
  /// Top Left Visible Cell
  /// </summary>
  public System.String? TopLeftCell { get ; set; }
  
  /// <summary>
  /// Color Id
  /// </summary>
  public System.UInt32? ColorId { get ; set; }
  
  /// <summary>
  /// Zoom Scale
  /// </summary>
  public System.UInt32? ZoomScale { get ; set; }
  
  /// <summary>
  /// Zoom Scale Normal View
  /// </summary>
  public System.UInt32? ZoomScaleNormal { get ; set; }
  
  /// <summary>
  /// Zoom Scale Page Break Preview
  /// </summary>
  public System.UInt32? ZoomScaleSheetLayoutView { get ; set; }
  
  /// <summary>
  /// Zoom Scale Page Layout View
  /// </summary>
  public System.UInt32? ZoomScalePageLayoutView { get ; set; }
  
  /// <summary>
  /// Workbook View Index
  /// </summary>
  public System.UInt32? WorkbookViewId { get ; set; }
  
  /// <summary>
  /// View Pane.
  /// </summary>
  public DocumentModel.Spreadsheet.IPane? Pane { get ; set; }
  
}
