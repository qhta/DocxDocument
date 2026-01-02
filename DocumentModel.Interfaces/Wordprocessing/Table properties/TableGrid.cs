namespace DocumentModel.Wordprocessing;
/// <summary>
///   Table Grid.
/// </summary>
public class TableGrid: BaseTableGrid
{
  
  /// <summary>
  /// Change record of previous Table Grid.
  /// </summary>
  public TableGridChange? TableGridChange { get; set; }
}