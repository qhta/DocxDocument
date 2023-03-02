namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Adjust Values.
/// </summary>
public record AdjustValueList
{
  public Collection<ShapeGuide>? ShapeGuides { get; set; }
}