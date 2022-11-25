namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Sheet View.
/// </summary>
public interface ICustomSheetView // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GUID
  /// </summary>
  public System.String? Guid { get ; set; }
  
  /// <summary>
  /// Print Scale
  /// </summary>
  public System.UInt32? Scale { get ; set; }
  
  /// <summary>
  /// Color Id
  /// </summary>
  public System.UInt32? ColorId { get ; set; }
  
  /// <summary>
  /// Show Page Breaks
  /// </summary>
  public System.Boolean? ShowPageBreaks { get ; set; }
  
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
  public System.Boolean? ShowRowColumn { get ; set; }
  
  /// <summary>
  /// Show Outline Symbols
  /// </summary>
  public System.Boolean? OutlineSymbols { get ; set; }
  
  /// <summary>
  /// Show Zero Values
  /// </summary>
  public System.Boolean? ZeroValues { get ; set; }
  
  /// <summary>
  /// Fit To Page
  /// </summary>
  public System.Boolean? FitToPage { get ; set; }
  
  /// <summary>
  /// Print Area Defined
  /// </summary>
  public System.Boolean? PrintArea { get ; set; }
  
  /// <summary>
  /// Filtered List
  /// </summary>
  public System.Boolean? Filter { get ; set; }
  
  /// <summary>
  /// Show AutoFitler Drop Down Controls
  /// </summary>
  public System.Boolean? ShowAutoFilter { get ; set; }
  
  /// <summary>
  /// Hidden Rows
  /// </summary>
  public System.Boolean? HiddenRows { get ; set; }
  
  /// <summary>
  /// Hidden Columns
  /// </summary>
  public System.Boolean? HiddenColumns { get ; set; }
  
  /// <summary>
  /// Visible State
  /// </summary>
  public DocumentModel.Spreadsheet.SheetStateKind? State { get ; set; }
  
  /// <summary>
  /// Filter
  /// </summary>
  public System.Boolean? FilterUnique { get ; set; }
  
  /// <summary>
  /// View Type
  /// </summary>
  public DocumentModel.Spreadsheet.SheetViewKind? View { get ; set; }
  
  /// <summary>
  /// Show Ruler
  /// </summary>
  public System.Boolean? ShowRuler { get ; set; }
  
  /// <summary>
  /// Top Left Visible Cell
  /// </summary>
  public System.String? TopLeftCell { get ; set; }
  
  /// <summary>
  /// Pane Split Information.
  /// </summary>
  public DocumentModel.Spreadsheet.IPane? Pane { get ; set; }
  
  /// <summary>
  /// Selection.
  /// </summary>
  public DocumentModel.Spreadsheet.ISelection? Selection { get ; set; }
  
  /// <summary>
  /// Horizontal Page Breaks.
  /// </summary>
  public DocumentModel.Spreadsheet.IPageBreakType? RowBreaks { get ; set; }
  
  /// <summary>
  /// Vertical Page Breaks.
  /// </summary>
  public DocumentModel.Spreadsheet.IPageBreakType? ColumnBreaks { get ; set; }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public DocumentModel.Spreadsheet.IPageMargins? PageMargins { get ; set; }
  
  /// <summary>
  /// Print Options.
  /// </summary>
  public DocumentModel.Spreadsheet.IPrintOptions? PrintOptions { get ; set; }
  
  /// <summary>
  /// Page Setup Settings.
  /// </summary>
  public DocumentModel.Spreadsheet.IPageSetup? PageSetup { get ; set; }
  
  /// <summary>
  /// Header Footer Settings.
  /// </summary>
  public DocumentModel.Spreadsheet.IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// AutoFilter Settings.
  /// </summary>
  public DocumentModel.Spreadsheet.IAutoFilter? AutoFilter { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
