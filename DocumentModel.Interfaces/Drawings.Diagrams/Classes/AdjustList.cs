namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Shape Adjust List.
/// </summary>
public interface AdjustList: IModelElement
{
  public Collection<Adjust>? Adjusts { get; set; }
}