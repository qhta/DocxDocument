namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Sheet View.
/// </summary>
public interface CustomSheetView // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// GUID
  /// </summary>
  public String? Guid { get ; set; }
  
  /// <summary>
  /// Print Scale
  /// </summary>
  public UInt32? Scale { get ; set; }
  
  /// <summary>
  /// Color Id
  /// </summary>
  public UInt32? ColorId { get ; set; }
  
  /// <summary>
  /// Show Page Breaks
  /// </summary>
  public Boolean? ShowPageBreaks { get ; set; }
  
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
  public Boolean? ShowRowColumn { get ; set; }
  
  /// <summary>
  /// Show Outline Symbols
  /// </summary>
  public Boolean? OutlineSymbols { get ; set; }
  
  /// <summary>
  /// Show Zero Values
  /// </summary>
  public Boolean? ZeroValues { get ; set; }
  
  /// <summary>
  /// Fit To Page
  /// </summary>
  public Boolean? FitToPage { get ; set; }
  
  /// <summary>
  /// Print Area Defined
  /// </summary>
  public Boolean? PrintArea { get ; set; }
  
  /// <summary>
  /// Filtered List
  /// </summary>
  public Boolean? Filter { get ; set; }
  
  /// <summary>
  /// Show AutoFitler Drop Down Controls
  /// </summary>
  public Boolean? ShowAutoFilter { get ; set; }
  
  /// <summary>
  /// Hidden Rows
  /// </summary>
  public Boolean? HiddenRows { get ; set; }
  
  /// <summary>
  /// Hidden Columns
  /// </summary>
  public Boolean? HiddenColumns { get ; set; }
  
  /// <summary>
  /// Visible State
  /// </summary>
  public SheetStateKind? State { get ; set; }
  
  /// <summary>
  /// Filter
  /// </summary>
  public Boolean? FilterUnique { get ; set; }
  
  /// <summary>
  /// View Type
  /// </summary>
  public SheetViewKind? View { get ; set; }
  
  /// <summary>
  /// Show Ruler
  /// </summary>
  public Boolean? ShowRuler { get ; set; }
  
  /// <summary>
  /// Top Left Visible Cell
  /// </summary>
  public String? TopLeftCell { get ; set; }
  
  /// <summary>
  /// Pane Split Information.
  /// </summary>
  public Pane? Pane { get ; set; }
  
  /// <summary>
  /// Selection.
  /// </summary>
  public Selection? Selection { get ; set; }
  
  /// <summary>
  /// Horizontal Page Breaks.
  /// </summary>
  public RowBreaks? RowBreaks { get ; set; }
  
  /// <summary>
  /// Vertical Page Breaks.
  /// </summary>
  public ColumnBreaks? ColumnBreaks { get ; set; }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public PageMargins? PageMargins { get ; set; }
  
  /// <summary>
  /// Print Options.
  /// </summary>
  public PrintOptions? PrintOptions { get ; set; }
  
  /// <summary>
  /// Page Setup Settings.
  /// </summary>
  public PageSetup? PageSetup { get ; set; }
  
  /// <summary>
  /// Header Footer Settings.
  /// </summary>
  public HeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// AutoFilter Settings.
  /// </summary>
  public AutoFilter? AutoFilter { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
