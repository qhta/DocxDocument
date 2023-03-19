namespace DocumentModel.Wordprocessing;

/// <summary>
///   Previous Table Grid.
/// </summary>
public class PreviousTableGrid: ModelElement
{
  public Collection<GridColumn>? GridColumns { get; set; }
}