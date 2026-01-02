namespace DocumentModel.Wordprocessing;

/// <summary>
///   ParagraphMarkRunPropertiesChange class used in <see cref="ParagraphMarkRunProperties"/>.
///   Represents <see cref="PreviousParagraphMarkRunProperties"/> annotated with Author, Date, and AnnotationId.
/// </summary>
public class ParagraphMarkRunPropertiesChange: ModelElement
{
  /// <summary>
  ///   author
  /// </summary>
  public string? Author { get; set; }
  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? AnnotationId { get; set; }
  /// <summary>
  ///   Previous Run Properties for the Paragraph Mark.
  /// </summary>
  public PreviousParagraphMarkRunProperties? PreviousParagraphMarkRunProperties { get; set; }
}