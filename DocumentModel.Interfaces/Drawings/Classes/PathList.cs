namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Paths.
/// </summary>
public interface PathList: IModelElement
{
  public Collection<Path>? Paths { get; set; }
}