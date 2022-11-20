namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Grid Column Definitions.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPreviousTableGrid))]
public class TableGridChange: ITableGridChange
{
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Table Grid.
  /// </summary>
  public IPreviousTableGrid? PreviousTableGrid
  {
    get;
    set;
  }
  
}
