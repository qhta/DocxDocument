namespace DocumentModel.Drawings;

/// <summary>
///   Line Default.
/// </summary>
public class LineDefault: ModelElement
{
  public ShapeProperties? ShapeProperties { get; set; }
  public BodyProperties? BodyProperties { get; set; }
  public ListStyle? ListStyle { get; set; }
  public ShapeStyle? ShapeStyle { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}