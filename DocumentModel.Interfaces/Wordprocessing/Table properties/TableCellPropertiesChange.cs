namespace DocumentModel.Wordprocessing;

/// <summary>
///   TableCellPropertiesChange class used in <see cref="TableCellProperties"/>.
///   Represents <see cref="PreviousTableCellProperties"/> annotated with Author, Date, and AnnotationId.
/// </summary>
public class TableCellPropertiesChange: ModelElement
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
  ///   Previous Table Cell Properties.
  /// </summary>
  public PreviousTableCellProperties? PreviousTableCellProperties { get; set; }
}