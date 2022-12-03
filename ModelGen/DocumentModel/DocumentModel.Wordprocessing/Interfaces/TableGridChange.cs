namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Grid Column Definitions.
/// </summary>
public interface TableGridChange // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Previous Table Grid.
  /// </summary>
  public PreviousTableGrid? PreviousTableGrid { get ; set; }
  
}
