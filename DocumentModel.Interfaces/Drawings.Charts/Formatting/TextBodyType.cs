namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents the text body structure containing body properties and list styles for chart elements.
/// </summary>
public interface TextBodyType
{
  /// <summary>
  /// Formatting properties for the body of the text, such as insets and text wrapping.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }

  /// <summary>
  /// Styles applied to bulleted or numbered lists within the text body.
  /// </summary>
  public ListStyle? ListStyle { get; set; }
}