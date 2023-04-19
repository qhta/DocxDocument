namespace DocumentModel.Wordprocessing;

/// <summary>
///   TablePropertiesChange class used in <see cref="TableProperties"/>.
///   Represents <see cref="PreviousTableProperties"/> annotated with Author, Date, and AnnotationId.
/// </summary>
public class TablePropertiesChange: ModelElement
{
  /// <summary>
  ///   Author.
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  ///   Date.
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier.
  /// </summary>
  public string? AnnotationId { get; set; }

  /// <summary>
  ///   Previous Table Properties.
  /// </summary>
  public PreviousTableProperties? PreviousTableProperties { get; set; }
}