namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Paths.
/// </summary>
public interface PathList
{
  public Collection<DocumentModel.Drawings.Path>? Paths { get ; set; }
  
}
