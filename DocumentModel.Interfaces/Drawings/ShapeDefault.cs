namespace DocumentModel.Drawings;

/// <summary>
///   Shape Default.
/// </summary>
public interface ShapeDefault: ExtendableElement
{
  public ShapeProperties? ShapeProperties { get; set; }
  public BodyProperties? BodyProperties { get; set; }
  public ListStyle? ListStyle { get; set; }
  public ShapeStyle? ShapeStyle { get; set; }
}