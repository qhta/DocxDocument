namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Paths.
/// </summary>
public class PathList: ModelElement
{
  public Collection<Path>? Paths { get; set; }
}