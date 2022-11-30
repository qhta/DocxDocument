namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell.
/// </summary>
public interface ICell // : DocumentModel.Spreadsheet.ICellType
{
  public DocumentModel.Spreadsheet.ICellFormula? CellFormula { get ; set; }
  
  public DocumentModel.Spreadsheet.IXstringType? CellValue { get ; set; }
  
  public DocumentModel.Spreadsheet.IInlineString? InlineString { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
