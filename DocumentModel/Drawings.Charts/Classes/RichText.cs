namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Rich Text.
/// </summary>
public record RichText
{
  public BodyProperties? BodyProperties { get; set; }

  public ListStyle? ListStyle { get; set; }

  public Paragraph? Paragraph { get; set; }
}