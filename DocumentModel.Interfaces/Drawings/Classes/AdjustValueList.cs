namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Adjust Values.
/// </summary>
public interface AdjustValueList: IModelElement
{
  public Collection<ShapeGuide>? ShapeGuides { get; set; }
}