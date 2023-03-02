namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Paths.
/// </summary>
public record PathList
{
  public Collection<Path>? Paths { get; set; }
}