namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the TextProperties Class.
/// </summary>
public record TextProperties
{
  public BodyProperties? BodyProperties { get; set; }

  public ListStyle? ListStyle { get; set; }

  public Paragraph? Paragraph { get; set; }
}