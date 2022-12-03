namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Data.
/// </summary>
public interface SheetData // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Row>? Rows { get ; set; }
  
}
