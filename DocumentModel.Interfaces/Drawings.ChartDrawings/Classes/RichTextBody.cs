namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the RichTextBody Class.
/// </summary>
public class RichTextBody: ModelElement
{
  public BodyProperties? BodyProperties { get; set; }
  public ListStyle? ListStyle { get; set; }
  public Paragraph? Paragraph { get; set; }
}