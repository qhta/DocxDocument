namespace DocumentModel.Spreadsheet;

/// <summary>
/// Worksheet.
/// </summary>
public interface Worksheet // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// SheetProperties.
  /// </summary>
  public SheetProperties? SheetProperties { get ; set; }
  
  /// <summary>
  /// SheetDimension.
  /// </summary>
  public SheetDimension? SheetDimension { get ; set; }
  
  /// <summary>
  /// SheetViews.
  /// </summary>
  public SheetViews? SheetViews { get ; set; }
  
  /// <summary>
  /// SheetFormatProperties.
  /// </summary>
  public SheetFormatProperties? SheetFormatProperties { get ; set; }
  
  public Collection<Columns>? Columnses { get ; set; }
  
  public SheetData? SheetData { get ; set; }
  
  public SheetCalculationProperties? SheetCalculationProperties { get ; set; }
  
  public SheetProtection? SheetProtection { get ; set; }
  
  public ProtectedRanges? ProtectedRanges { get ; set; }
  
  public Scenarios? Scenarios { get ; set; }
  
  public AutoFilter? AutoFilter { get ; set; }
  
  public SortState? SortState { get ; set; }
  
  public DataConsolidate? DataConsolidate { get ; set; }
  
  public CustomSheetViews? CustomSheetViews { get ; set; }
  
  public MergeCells? MergeCells { get ; set; }
  
  public PhoneticProperties? PhoneticProperties { get ; set; }
  
  public Collection<ConditionalFormatting>? ConditionalFormattings { get ; set; }
  
  public DataValidations? DataValidations { get ; set; }
  
  public Hyperlinks? Hyperlinks { get ; set; }
  
  public PrintOptions? PrintOptions { get ; set; }
  
  public PageMargins? PageMargins { get ; set; }
  
  public PageSetup? PageSetup { get ; set; }
  
  public HeaderFooter? HeaderFooter { get ; set; }
  
  public RowBreaks? RowBreaks { get ; set; }
  
  public ColumnBreaks? ColumnBreaks { get ; set; }
  
  public CustomProperties? CustomProperties { get ; set; }
  
  public CellWatches? CellWatches { get ; set; }
  
  public IgnoredErrors? IgnoredErrors { get ; set; }
  
  public Drawing? Drawing { get ; set; }
  
  public LegacyDrawingType? LegacyDrawing { get ; set; }
  
  public LegacyDrawingType? LegacyDrawingHeaderFooter { get ; set; }
  
  public DrawingHeaderFooter? DrawingHeaderFooter { get ; set; }
  
  public Picture? Picture { get ; set; }
  
  public OleObjects? OleObjects { get ; set; }
  
  public Controls? Controls { get ; set; }
  
  public WebPublishItems? WebPublishItems { get ; set; }
  
  public TableParts? TableParts { get ; set; }
  
  public WorksheetExtensionList? WorksheetExtensionList { get ; set; }
  
}
