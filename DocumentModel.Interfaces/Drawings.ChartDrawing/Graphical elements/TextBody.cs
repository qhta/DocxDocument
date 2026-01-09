namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes the text body of a shape in chart drawings, including body formatting, list styles, and paragraph content.
/// </summary>
public interface TextBody
{
  /// <summary>
  /// Formatting properties for the text body, such as insets, wrapping, and rotation.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }

  /// <summary>
  /// Styles applied to bulleted or numbered lists within the text body.
  /// </summary>
  public ListStyle? ListStyle { get; set; }

  /// <summary>
  /// Paragraph content and formatting within the text body.
  /// </summary>
  public Paragraph? Paragraph { get; set; }
}