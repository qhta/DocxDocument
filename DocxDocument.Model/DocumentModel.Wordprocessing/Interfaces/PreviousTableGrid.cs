namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Grid.
/// </summary>
public partial interface PreviousTableGrid
{
  public Collection<DocumentModel.Wordprocessing.GridColumn>? GridColumns { get; set; }
  
}
