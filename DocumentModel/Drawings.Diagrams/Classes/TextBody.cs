namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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