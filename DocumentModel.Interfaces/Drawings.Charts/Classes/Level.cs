namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Level.
/// </summary>
public interface Level:
{
  public Collection<StringPoint>? StringPoints { get; set; }
}