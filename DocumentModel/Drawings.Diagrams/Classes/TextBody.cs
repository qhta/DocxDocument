namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Text Body.
/// </summary>
public class TextBody: ModelElement
{
  /// <summary>
  ///   Body Properties.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }

  /// <summary>
  ///   Text List Styles.
  /// </summary>
  public ListStyle? ListStyle { get; set; }

  public Paragraph? Paragraph { get; set; }
}