namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Adjust Values.
/// </summary>
public interface AdjustValueList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ShapeGuide>? ShapeGuides { get ; set; }
  
}
