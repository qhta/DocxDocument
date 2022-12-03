namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell.
/// </summary>
public interface Cell // : DocumentModel.Spreadsheet.CellType
{
  public CellFormula? CellFormula { get ; set; }
  
  public XstringType? CellValue { get ; set; }
  
  public InlineString? InlineString { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
