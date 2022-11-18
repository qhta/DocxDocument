namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Sheet View.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IAutoFilter))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IHeaderFooter))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRowBreaks))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColumnBreaks))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPageMargins))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPageSetup))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPane))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPrintOptions))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISelection))]
public interface ICustomSheetView // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// GUID
  /// </summary>
  public string? Guid { get ; set; }
  
  /// <summary>
  /// Print Scale
  /// </summary>
  public uint? Scale { get ; set; }
  
  /// <summary>
  /// Color Id
  /// </summary>
  public uint? ColorId { get ; set; }
  
  /// <summary>
  /// Show Page Breaks
  /// </summary>
  public bool? ShowPageBreaks { get ; set; }
  
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
  public bool? ShowRowColumn { get ; set; }
  
  /// <summary>
  /// Show Outline Symbols
  /// </summary>
  public bool? OutlineSymbols { get ; set; }
  
  /// <summary>
  /// Show Zero Values
  /// </summary>
  public bool? ZeroValues { get ; set; }
  
  /// <summary>
  /// Fit To Page
  /// </summary>
  public bool? FitToPage { get ; set; }
  
  /// <summary>
  /// Print Area Defined
  /// </summary>
  public bool? PrintArea { get ; set; }
  
  /// <summary>
  /// Filtered List
  /// </summary>
  public bool? Filter { get ; set; }
  
  /// <summary>
  /// Show AutoFitler Drop Down Controls
  /// </summary>
  public bool? ShowAutoFilter { get ; set; }
  
  /// <summary>
  /// Hidden Rows
  /// </summary>
  public bool? HiddenRows { get ; set; }
  
  /// <summary>
  /// Hidden Columns
  /// </summary>
  public bool? HiddenColumns { get ; set; }
  
  /// <summary>
  /// Visible State
  /// </summary>
  public SheetState? State { get ; set; }
  
  /// <summary>
  /// Filter
  /// </summary>
  public bool? FilterUnique { get ; set; }
  
  /// <summary>
  /// View Type
  /// </summary>
  public SheetView? View { get ; set; }
  
  /// <summary>
  /// Show Ruler
  /// </summary>
  public bool? ShowRuler { get ; set; }
  
  /// <summary>
  /// Top Left Visible Cell
  /// </summary>
  public string? TopLeftCell { get ; set; }
  
  /// <summary>
  /// Pane Split Information.
  /// </summary>
  public IPane? Pane { get ; set; }
  
  /// <summary>
  /// Selection.
  /// </summary>
  public DocumentModel.Spreadsheet.ISelection? Selection { get ; set; }
  
  /// <summary>
  /// Horizontal Page Breaks.
  /// </summary>
  public IRowBreaks? RowBreaks { get ; set; }
  
  /// <summary>
  /// Vertical Page Breaks.
  /// </summary>
  public IColumnBreaks? ColumnBreaks { get ; set; }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  public DocumentModel.Spreadsheet.IPageMargins? PageMargins { get ; set; }
  
  /// <summary>
  /// Print Options.
  /// </summary>
  public IPrintOptions? PrintOptions { get ; set; }
  
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
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
