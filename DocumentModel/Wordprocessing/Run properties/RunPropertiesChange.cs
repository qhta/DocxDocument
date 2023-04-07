namespace DocumentModel.Wordprocessing;

/// <summary>
///   RunPropertiesChange class used in <see cref="RunProperties"/>.
///   Represents <see cref="PreviousRunProperties"/> annotated with Author, Date, and AnnotationId.
/// </summary>
public class RunPropertiesChange: ModelElement
{
  /// <summary>
  ///   author
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? AnnotationId { get; set; }

  /// <summary>
  ///   Previous Run Properties.
  /// </summary>
  public PreviousRunProperties? PreviousRunProperties { get; set; }
}