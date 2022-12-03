namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Paths.
/// </summary>
public interface PathList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Path>? Paths { get ; set; }
  
}
