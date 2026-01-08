namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents text formatting and layout properties for chart elements.
///   This interface allows configuration of body properties, list styles, and paragraph formatting for text displayed in charts, such as titles, labels, or legends.
/// </summary>
public interface TextProperties
{
  /// <summary>
  ///   Properties that define the overall text body formatting, such as rotation, anchor, and wrapping.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }

  /// <summary>
  ///   List style settings for text, including bullet and numbering options.
  /// </summary>
  public ListStyle? ListStyle { get; set; }

  /// <summary>
  ///   Paragraph formatting and content for the text, including alignment, indentation, and runs.
  /// </summary>
  public Paragraph? Paragraph { get; set; }
}