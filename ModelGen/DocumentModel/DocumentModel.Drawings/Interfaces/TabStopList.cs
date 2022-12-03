namespace DocumentModel.Drawings;

/// <summary>
/// Tab List.
/// </summary>
public interface TabStopList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<TabStop>? TabStops { get ; set; }
  
}
