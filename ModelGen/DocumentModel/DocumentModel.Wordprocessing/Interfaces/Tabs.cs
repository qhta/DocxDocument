namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public interface Tabs // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<TabStop>? TabStops { get ; set; }
  
}
