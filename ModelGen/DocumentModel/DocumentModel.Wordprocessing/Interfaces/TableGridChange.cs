namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Grid Column Definitions.
/// </summary>
public interface TableGridChange
{
  /// <summary>
  /// Previous Table Grid.
  /// </summary>
  public PreviousTableGrid? PreviousTableGrid { get ; set; }
  
}
