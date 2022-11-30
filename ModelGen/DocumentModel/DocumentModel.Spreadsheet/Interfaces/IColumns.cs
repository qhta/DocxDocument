namespace DocumentModel.Spreadsheet;

/// <summary>
/// Column Information.
/// </summary>
public interface IColumns // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IColumn>? Columns { get ; set; }
  
}
