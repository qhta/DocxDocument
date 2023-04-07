namespace DocumentModel.Wordprocessing;

/// <summary>
///   ParagraphPropertiesChange class used in <see cref="ParagraphProperties"/>.
///   Represents <see cref="PreviousParagraphProperties"/> annotated with Author, Date, and annotation Id.
/// </summary>
public class ParagraphPropertiesChange: ModelElement
{
  /// <summary>
  ///   Author
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   Sate
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? AnnotationId { get; set; }

  /// <summary>
  ///   Previous Paragraph Properties.
  /// </summary>
  public PreviousParagraphProperties? PreviousParagraphProperties { get; set; }
}