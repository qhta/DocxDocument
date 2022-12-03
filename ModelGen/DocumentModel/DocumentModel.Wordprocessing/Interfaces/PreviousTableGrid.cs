namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Grid.
/// </summary>
public interface PreviousTableGrid // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<GridColumn>? GridColumns { get ; set; }
  
}
