namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Grid.
/// </summary>
public interface TableGrid // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<GridColumn>? GridColumns { get ; set; }
  
  public TableGridChange? TableGridChange { get ; set; }
  
}
