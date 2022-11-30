namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Data.
/// </summary>
public interface ISheetData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IRow>? Rows { get ; set; }
  
}
