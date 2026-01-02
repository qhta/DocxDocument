namespace DocumentModel.Drawings;

/// <summary>
///   Tab List.
/// </summary>
public class TabStopList: ModelElement
{
  public Collection<TabStop>? TabStops { get; set; }
}