namespace DocumentModel.Wordprocessing;

/// <summary>
///   Table Grid.
/// </summary>
public class TableGrid
{
  public Collection<GridColumn>? GridColumns { get; set; }

  public TableGridChange? TableGridChange { get; set; }
}