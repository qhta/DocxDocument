namespace DocumentModel.Wordprocessing;

/// <summary>
///   Previous Table Grid.
/// </summary>
public record PreviousTableGrid
{
  public Collection<GridColumn>? GridColumns { get; set; }
}