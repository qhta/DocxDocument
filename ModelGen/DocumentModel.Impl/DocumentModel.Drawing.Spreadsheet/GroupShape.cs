namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Group Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IGroupShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IConnectionShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IGraphicFrame))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IGroupShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualGroupShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IShape))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.Drawing.IContentPart))]
public class GroupShape: IGroupShape
{
  /// <summary>
  /// Non-Visual Properties for a Group Shape.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualGroupShapeProperties? NonVisualGroupShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IGroupShapeProperties? GroupShapeProperties
  {
    get;
    set;
  }
  
}
