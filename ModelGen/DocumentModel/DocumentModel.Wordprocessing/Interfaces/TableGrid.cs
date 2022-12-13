namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Grid.
/// </summary>
public interface TableGrid
{
  public Collection<DocumentModel.Wordprocessing.GridColumn>? GridColumns { get ; set; }
  
  public DocumentModel.Wordprocessing.TableGridChange? TableGridChange { get ; set; }
  
}
