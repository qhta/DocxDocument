namespace DocumentModel.Wordprocessing;
/// <summary>
///   TableRowPropertiesChange class used in <see cref="TableRowProperties"/>.
///   Represents <see cref="PreviousTableRowProperties"/> annotated with Author, Date, and AnnotationId.
/// </summary>
public class TableRowPropertiesChange: ModelElement
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
  ///   Previous Table Row Properties.
  /// </summary>
  public PreviousTableRowProperties? PreviousTableRowProperties { get; set; }
}