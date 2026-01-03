namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Level.
/// </summary>
public interface Level: IModelElement
{
  public Collection<StringPoint>? StringPoints { get; set; }
}