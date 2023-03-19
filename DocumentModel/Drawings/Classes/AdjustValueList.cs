namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Adjust Values.
/// </summary>
public class AdjustValueList: ModelElement
{
  public Collection<ShapeGuide>? ShapeGuides { get; set; }
}