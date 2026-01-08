namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents rich text content in a chart.
///   This interface allows defining formatting properties, list styles, and paragraph content for text elements.
/// </summary>
public interface RichText
{
  /// <summary>
  ///   Body formatting properties for the rich text.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }

  /// <summary>
  ///   List style definitions for the rich text.
  /// </summary>
  public ListStyle? ListStyle { get; set; }

  /// <summary>
  ///   Paragraph content within the rich text.
  /// </summary>
  public Paragraph? Paragraph { get; set; }
}