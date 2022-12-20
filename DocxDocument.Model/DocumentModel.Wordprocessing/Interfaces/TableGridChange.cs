namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Grid Column Definitions.
/// </summary>
public partial interface TableGridChange
{
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// Previous Table Grid.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousTableGrid? PreviousTableGrid { get; set; }
  
}
