namespace DocumentModel.Wordprocessing;
/// <summary>
///   Table Grid.
/// </summary>
public interface TableGrid: BaseTableGrid
{
  
  /// <summary>
  /// Change interface of previous Table Grid.
  /// </summary>
  public TableGridChange? TableGridChange { get; set; }
}