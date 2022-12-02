namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Grid.
/// </summary>
public interface ITableGrid // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IGridColumn>? GridColumns { get ; set; }
  
  public ITableGridChange? TableGridChange { get ; set; }
  
}
