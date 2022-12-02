namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CellWatches Class.
/// </summary>
public interface ICellWatches // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICellWatch>? CellWatchs { get ; set; }
  
}
