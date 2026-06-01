namespace DocumentModel.Wordprocessing;

/// <summary>
///   ITable Grid.
/// </summary>
public class TableGrid: BaseTableGrid
{
  
  /// <summary>
  /// Change record of previous ITable Grid.
  /// </summary>
  public TableGridChange? TableGridChange { get; set; }
}
