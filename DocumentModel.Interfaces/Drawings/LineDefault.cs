namespace DocumentModel.Drawings;

/// <summary>
///   Line Default.
/// </summary>
public interface LineDefault: ExtendableElement
{
  public ShapeProperties? ShapeProperties { get; set; }
  public BodyProperties? BodyProperties { get; set; }
  public ListStyle? ListStyle { get; set; }
  public ShapeStyle? ShapeStyle { get; set; }
}