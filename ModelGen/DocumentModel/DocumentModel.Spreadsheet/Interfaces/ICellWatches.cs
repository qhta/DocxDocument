namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CellWatches Class.
/// </summary>
public interface ICellWatches // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICellWatch>? CellWatchs { get ; set; }
  
}
