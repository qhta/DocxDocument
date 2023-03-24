namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Rich Text.
/// </summary>
public class RichText: ModelElement
{
  public BodyProperties? BodyProperties { get; set; }

  public ListStyle? ListStyle { get; set; }

  public Paragraph? Paragraph { get; set; }
}