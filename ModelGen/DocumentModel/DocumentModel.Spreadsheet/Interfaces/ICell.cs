namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell.
/// </summary>
public interface ICell // : DocumentModel.Spreadsheet.ICellType
{
  public ICellFormula? CellFormula { get ; set; }
  
  public IXstringType? CellValue { get ; set; }
  
  public IInlineString? InlineString { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
