namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Data.
/// </summary>
public interface ISheetData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IRow>? Rows { get ; set; }
  
}
