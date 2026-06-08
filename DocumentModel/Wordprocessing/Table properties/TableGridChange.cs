namespace DocumentModel.Wordprocessing;

/// <summary>
///   IRevision Information for ITable Grid IColumn Definitions.
/// </summary>
public class TableGridChange: ModelElement
{
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? AnnotationId { get; set; }

  /// <summary>
  ///   Previous ITable Grid.
  /// </summary>
  public PreviousTableGrid? PreviousTableGrid { get; set; }
}
