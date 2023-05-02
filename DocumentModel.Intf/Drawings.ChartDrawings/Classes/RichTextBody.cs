namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the RichTextBody Class.
/// </summary>
public class RichTextBody: ModelElement
{
  public BodyProperties? BodyProperties { get; set; }

  public ListStyle? ListStyle { get; set; }

  public Paragraph? Paragraph { get; set; }
}