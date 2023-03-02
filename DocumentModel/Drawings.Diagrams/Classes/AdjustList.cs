namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Shape Adjust List.
/// </summary>
public record AdjustList
{
  public Collection<Adjust>? Adjusts { get; set; }
}