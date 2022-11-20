namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Grid.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableGridChange))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IGridColumn))]
public class TableGrid: ITableGrid
{
}
