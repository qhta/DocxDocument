namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RefMap Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRefCell))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRefFuture))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRefOartAnchor))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRefTest))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.ISheetXluid))]
public class RefMap: IRefMap
{
}
