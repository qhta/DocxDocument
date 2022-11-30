namespace DocumentModel.Spreadsheet;

/// <summary>
/// Worksheet.
/// </summary>
public interface IWorksheet // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// SheetProperties.
  /// </summary>
  public DocumentModel.Spreadsheet.ISheetProperties? SheetProperties { get ; set; }
  
  /// <summary>
  /// SheetDimension.
  /// </summary>
  public DocumentModel.Spreadsheet.ISheetDimension? SheetDimension { get ; set; }
  
  /// <summary>
  /// SheetViews.
  /// </summary>
  public DocumentModel.Spreadsheet.ISheetViews? SheetViews { get ; set; }
  
  /// <summary>
  /// SheetFormatProperties.
  /// </summary>
  public DocumentModel.Spreadsheet.ISheetFormatProperties? SheetFormatProperties { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IColumns>? Columnses { get ; set; }
  
  public DocumentModel.Spreadsheet.ISheetData? SheetData { get ; set; }
  
  public DocumentModel.Spreadsheet.ISheetCalculationProperties? SheetCalculationProperties { get ; set; }
  
  public DocumentModel.Spreadsheet.ISheetProtection? SheetProtection { get ; set; }
  
  public DocumentModel.Spreadsheet.IProtectedRanges? ProtectedRanges { get ; set; }
  
  public DocumentModel.Spreadsheet.IScenarios? Scenarios { get ; set; }
  
  public DocumentModel.Spreadsheet.IAutoFilter? AutoFilter { get ; set; }
  
  public DocumentModel.Spreadsheet.ISortState? SortState { get ; set; }
  
  public DocumentModel.Spreadsheet.IDataConsolidate? DataConsolidate { get ; set; }
  
  public DocumentModel.Spreadsheet.ICustomSheetViews? CustomSheetViews { get ; set; }
  
  public DocumentModel.Spreadsheet.IMergeCells? MergeCells { get ; set; }
  
  public DocumentModel.Spreadsheet.IPhoneticProperties? PhoneticProperties { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IConditionalFormatting>? ConditionalFormattings { get ; set; }
  
  public DocumentModel.Spreadsheet.IDataValidations? DataValidations { get ; set; }
  
  public DocumentModel.Spreadsheet.IHyperlinks? Hyperlinks { get ; set; }
  
  public DocumentModel.Spreadsheet.IPrintOptions? PrintOptions { get ; set; }
  
  public DocumentModel.Spreadsheet.IPageMargins? PageMargins { get ; set; }
  
  public DocumentModel.Spreadsheet.IPageSetup? PageSetup { get ; set; }
  
  public DocumentModel.Spreadsheet.IHeaderFooter? HeaderFooter { get ; set; }
  
  public DocumentModel.Spreadsheet.IRowBreaks? RowBreaks { get ; set; }
  
  public DocumentModel.Spreadsheet.IColumnBreaks? ColumnBreaks { get ; set; }
  
  public DocumentModel.Spreadsheet.ICustomProperties? CustomProperties { get ; set; }
  
  public DocumentModel.Spreadsheet.ICellWatches? CellWatches { get ; set; }
  
  public DocumentModel.Spreadsheet.IIgnoredErrors? IgnoredErrors { get ; set; }
  
  public DocumentModel.Spreadsheet.IDrawing? Drawing { get ; set; }
  
  public DocumentModel.Spreadsheet.ILegacyDrawingType? LegacyDrawing { get ; set; }
  
  public DocumentModel.Spreadsheet.ILegacyDrawingType? LegacyDrawingHeaderFooter { get ; set; }
  
  public DocumentModel.Spreadsheet.IDrawingHeaderFooter? DrawingHeaderFooter { get ; set; }
  
  public DocumentModel.Spreadsheet.IPicture? Picture { get ; set; }
  
  public DocumentModel.Spreadsheet.IOleObjects? OleObjects { get ; set; }
  
  public DocumentModel.Spreadsheet.IControls? Controls { get ; set; }
  
  public DocumentModel.Spreadsheet.IWebPublishItems? WebPublishItems { get ; set; }
  
  public DocumentModel.Spreadsheet.ITableParts? TableParts { get ; set; }
  
  public DocumentModel.Spreadsheet.IWorksheetExtensionList? WorksheetExtensionList { get ; set; }
  
}
