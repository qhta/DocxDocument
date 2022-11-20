namespace DocumentModel.Presentation;

/// <summary>
/// Group Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IGroupShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IConnectionShape))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IContentPart))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionListWithModification))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IGraphicFrame))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IGroupShape))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualGroupShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IShape))]
public class GroupShape: IGroupShape
{
  /// <summary>
  /// Non-Visual Properties for a Group Shape.
  /// </summary>
  public DocumentModel.Presentation.INonVisualGroupShapeProperties? NonVisualGroupShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public DocumentModel.Presentation.IGroupShapeProperties? GroupShapeProperties
  {
    get;
    set;
  }
  
}
