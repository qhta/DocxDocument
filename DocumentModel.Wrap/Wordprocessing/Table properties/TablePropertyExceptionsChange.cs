namespace DocumentModel.Wordprocessing;

/// <summary>
///   TablePropertyExceptionsChange class used in <see cref="TablePropertyExceptions"/>.
///   Represents <see cref="PreviousTablePropertyExceptions"/> annotated with Author, Date, and AnnotationId.
/// </summary>
public class TablePropertyExceptionsChange: ModelElement
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
  ///   Previous Table-Level Property Exceptions.
  /// </summary>
  public PreviousTablePropertyExceptions? PreviousTablePropertyExceptions { get; set; }
}