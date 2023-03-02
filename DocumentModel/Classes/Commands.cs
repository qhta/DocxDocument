namespace DocumentModel;

/// <summary>
///   Defines the Commands Class.
/// </summary>
public record Commands
{
  public Collection<Command>? Items { get; set; }
}