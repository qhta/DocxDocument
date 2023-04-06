namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Table Grid.
/// </summary>
public class TableGrid: ModelElement
{
  public Collection<GridColumn>? GridColumns { get; set; }

  public TableGridChange? TableGridChange { get; set; }
}