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
  public DocumentModel.BaseTypes.ModelElement? SheetViews { get ; set; }
  
  /// <summary>
  /// SheetFormatProperties.
  /// </summary>
  public DocumentModel.Spreadsheet.ISheetFormatProperties? SheetFormatProperties { get ; set; }
  
}
