namespace DocumentModel.Wordprocessing;

/// <summary>
///   Revision Information for Table Grid Column Definitions.
/// </summary>
public class TableGridChange: ModelElement
{
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? AnnotationId { get; set; }

  /// <summary>
  ///   Previous Table Grid.
  /// </summary>
  public PreviousTableGrid? PreviousTableGrid { get; set; }
}