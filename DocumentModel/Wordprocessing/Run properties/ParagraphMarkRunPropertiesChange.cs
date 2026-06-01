namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   ParagraphMarkRunPropertiesChange class used Iin <see cref="ParagraphMarkRunProperties"/>.
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
  ///   Previous Run Properties Ifor the IParagraph Mark.
  /// </summary>
  public PreviousParagraphMarkRunProperties? PreviousParagraphMarkRunProperties { get; set; }
}
