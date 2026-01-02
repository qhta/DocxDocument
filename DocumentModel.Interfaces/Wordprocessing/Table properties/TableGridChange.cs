namespace DocumentModel.Wordprocessing;
/// <summary>
///   Revision Information for Table Grid IColumn Definitions.
/// </summary>
public class TableGridChange: ModelElement
{
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? AnnotationId { get; set; }
  /// <summary>
  ///   Previous Table Grid.
  /// </summary>
  public PreviousTableGrid? PreviousTableGrid { get; set; }
}