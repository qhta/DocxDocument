namespace DocumentModel.Drawings;

/// <summary>
/// Tab List.
/// </summary>
public partial interface TabStopList
{
  public Collection<DocumentModel.Drawings.TabStop>? TabStops { get; set; }
  
}
