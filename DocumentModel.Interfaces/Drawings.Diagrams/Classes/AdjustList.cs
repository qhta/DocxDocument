namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Shape Adjust List.
/// </summary>
public class AdjustList: ModelElement
{
  public Collection<Adjust>? Adjusts { get; set; }
}