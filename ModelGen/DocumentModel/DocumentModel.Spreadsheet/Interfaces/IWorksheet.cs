namespace DocumentModel.Spreadsheet;

/// <summary>
/// Worksheet.
/// </summary>
public interface IWorksheet // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// SheetProperties.
  /// </summary>
  public ISheetProperties? SheetProperties { get ; set; }
  
  /// <summary>
  /// SheetDimension.
  /// </summary>
  public ISheetDimension? SheetDimension { get ; set; }
  
  /// <summary>
  /// SheetViews.
  /// </summary>
  public ISheetViews? SheetViews { get ; set; }
  
  /// <summary>
  /// SheetFormatProperties.
  /// </summary>
  public ISheetFormatProperties? SheetFormatProperties { get ; set; }
  
  public Collection<IColumns>? Columnses { get ; set; }
  
  public ISheetData? SheetData { get ; set; }
  
  public ISheetCalculationProperties? SheetCalculationProperties { get ; set; }
  
  public ISheetProtection? SheetProtection { get ; set; }
  
  public IProtectedRanges? ProtectedRanges { get ; set; }
  
  public IScenarios? Scenarios { get ; set; }
  
  public IAutoFilter? AutoFilter { get ; set; }
  
  public ISortState? SortState { get ; set; }
  
  public IDataConsolidate? DataConsolidate { get ; set; }
  
  public ICustomSheetViews? CustomSheetViews { get ; set; }
  
  public IMergeCells? MergeCells { get ; set; }
  
  public IPhoneticProperties? PhoneticProperties { get ; set; }
  
  public Collection<IConditionalFormatting>? ConditionalFormattings { get ; set; }
  
  public IDataValidations? DataValidations { get ; set; }
  
  public IHyperlinks? Hyperlinks { get ; set; }
  
  public IPrintOptions? PrintOptions { get ; set; }
  
  public IPageMargins? PageMargins { get ; set; }
  
  public IPageSetup? PageSetup { get ; set; }
  
  public IHeaderFooter? HeaderFooter { get ; set; }
  
  public IRowBreaks? RowBreaks { get ; set; }
  
  public IColumnBreaks? ColumnBreaks { get ; set; }
  
  public ICustomProperties? CustomProperties { get ; set; }
  
  public ICellWatches? CellWatches { get ; set; }
  
  public IIgnoredErrors? IgnoredErrors { get ; set; }
  
  public IDrawing? Drawing { get ; set; }
  
  public ILegacyDrawingType? LegacyDrawing { get ; set; }
  
  public ILegacyDrawingType? LegacyDrawingHeaderFooter { get ; set; }
  
  public IDrawingHeaderFooter? DrawingHeaderFooter { get ; set; }
  
  public IPicture? Picture { get ; set; }
  
  public IOleObjects? OleObjects { get ; set; }
  
  public IControls? Controls { get ; set; }
  
  public IWebPublishItems? WebPublishItems { get ; set; }
  
  public ITableParts? TableParts { get ; set; }
  
  public IWorksheetExtensionList? WorksheetExtensionList { get ; set; }
  
}
