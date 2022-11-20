namespace DocumentModel.Drawing;

/// <summary>
/// Table.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableGrid))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableRow))]
public class Table: ITable
{
  /// <summary>
  /// Table Properties.
  /// </summary>
  public DocumentModel.Drawing.ITableProperties? TableProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Grid.
  /// </summary>
  public DocumentModel.Drawing.ITableGrid? TableGrid
  {
    get;
    set;
  }
  
}
