namespace DocumentModel.Wordprocessing;
/// <summary>
///   ParagraphPropertiesChange interface used in <see cref="ParagraphProperties"/>.
///   Represents <see cref="PreviousParagraphProperties"/> annotated with Author, Date, and AnnotationId.
/// </summary>
public interface ParagraphPropertiesChange
{
  /// <summary>
  ///   Author
  /// </summary>
  public string? Author { get; set; }
  /// <summary>
  ///   Sate
  /// </summary>
  public DateTime? Date { get; set; }
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? AnnotationId { get; set; }
  /// <summary>
  ///   Previous Paragraph Properties.
  /// </summary>
  public PreviousParagraphProperties? PreviousParagraphProperties { get; set; }
}