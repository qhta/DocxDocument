namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingGroup.IGroupShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingGroup.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingGroup.INonVisualGroupDrawingShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingGroup.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Pictures.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IContentPart))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingGroup.IGraphicFrame))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingGroup.IGroupShape))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.IWordprocessingShape))]
public class GroupShape: IGroupShape
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingGroup.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingGroup.INonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingGroup.IGroupShapeProperties? GroupShapeProperties
  {
    get;
    set;
  }
  
}
