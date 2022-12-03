namespace DocumentModel.Spreadsheet;

/// <summary>
/// Worksheet View.
/// </summary>
public interface SheetView // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Window Protection
  /// </summary>
  public Boolean? WindowProtection { get ; set; }
  
  /// <summary>
  /// Show Formulas
  /// </summary>
  public Boolean? ShowFormulas { get ; set; }
  
  /// <summary>
  /// Show Grid Lines
  /// </summary>
  public Boolean? ShowGridLines { get ; set; }
  
  /// <summary>
  /// Show Headers
  /// </summary>
  public Boolean? ShowRowColHeaders { get ; set; }
  
  /// <summary>
  /// Show Zero Values
  /// </summary>
  public Boolean? ShowZeros { get ; set; }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  public Boolean? RightToLeft { get ; set; }
  
  /// <summary>
  /// Sheet Tab Selected
  /// </summary>
  public Boolean? TabSelected { get ; set; }
  
  /// <summary>
  /// Show Ruler
  /// </summary>
  public Boolean? ShowRuler { get ; set; }
  
  /// <summary>
  /// Show Outline Symbols
  /// </summary>
  public Boolean? ShowOutlineSymbols { get ; set; }
  
  /// <summary>
  /// Default Grid Color
  /// </summary>
  public Boolean? DefaultGridColor { get ; set; }
  
  /// <summary>
  /// Show White Space
  /// </summary>
  public Boolean? ShowWhiteSpace { get ; set; }
  
  /// <summary>
  /// View Type
  /// </summary>
  public SheetViewKind? View { get ; set; }
  
  /// <summary>
  /// Top Left Visible Cell
  /// </summary>
  public String? TopLeftCell { get ; set; }
  
  /// <summary>
  /// Color Id
  /// </summary>
  public UInt32? ColorId { get ; set; }
  
  /// <summary>
  /// Zoom Scale
  /// </summary>
  public UInt32? ZoomScale { get ; set; }
  
  /// <summary>
  /// Zoom Scale Normal View
  /// </summary>
  public UInt32? ZoomScaleNormal { get ; set; }
  
  /// <summary>
  /// Zoom Scale Page Break Preview
  /// </summary>
  public UInt32? ZoomScaleSheetLayoutView { get ; set; }
  
  /// <summary>
  /// Zoom Scale Page Layout View
  /// </summary>
  public UInt32? ZoomScalePageLayoutView { get ; set; }
  
  /// <summary>
  /// Workbook View Index
  /// </summary>
  public UInt32? WorkbookViewId { get ; set; }
  
  /// <summary>
  /// View Pane.
  /// </summary>
  public Pane? Pane { get ; set; }
  
  public Collection<Selection>? Selections { get ; set; }
  
  public Collection<PivotSelection>? PivotSelections { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
