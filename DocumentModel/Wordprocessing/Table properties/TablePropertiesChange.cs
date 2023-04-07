namespace DocumentModel.Wordprocessing;

/// <summary>
///   RunPropertiesChange class used in <see cref="TableProperties"/>.
///   Represents <see cref="PreviousTableProperties"/> annotated with Author, Date, and AnnotationId.
/// </summary>
public class TablePropertiesChange: ModelElement
{
  /// <summary>
  ///   Author.
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   Date.
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier.
  /// </summary>
  public String? AnnotationId { get; set; }

  /// <summary>
  ///   Previous Table Properties.
  /// </summary>
  public PreviousTableProperties? PreviousTableProperties { get; set; }
}