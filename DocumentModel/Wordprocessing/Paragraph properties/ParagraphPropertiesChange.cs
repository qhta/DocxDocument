namespace DocumentModel.Wordprocessing;

/// <summary>
///   ParagraphPropertiesChange class used Iin <see cref="ParagraphProperties"/>.
///   Represents <see cref="PreviousParagraphProperties"/> annotated with Author, Date, and AnnotationId.
/// </summary>
public class ParagraphPropertiesChange: ModelElement
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
  ///   Previous IParagraph Properties.
  /// </summary>
  public PreviousParagraphProperties? PreviousParagraphProperties { get; set; }
}
