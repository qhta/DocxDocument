namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Level.
/// </summary>
public record Level
{
  public Collection<StringPoint>? StringPoints { get; set; }
}