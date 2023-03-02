namespace DocumentModel.Drawings;

/// <summary>
///   Tab List.
/// </summary>
public record TabStopList
{
  public Collection<TabStop>? TabStops { get; set; }
}