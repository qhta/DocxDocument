namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the RichTextBody Class.
/// </summary>
public record RichTextBody
{
  public BodyProperties? BodyProperties { get; set; }

  public ListStyle? ListStyle { get; set; }

  public Paragraph? Paragraph { get; set; }
}