namespace DocumentModel.Drawing.LockedCanvas;

/// <summary>
/// Locked Canvas Container.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IVisualGroupShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IConnectionShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphicFrame))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGvmlGroupShapeExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualGroupShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITextShape))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IGvmlContentPart))]
public class LockedCanvas: ILockedCanvas
{
  /// <summary>
  /// Non-Visual Properties for a Group Shape.
  /// </summary>
  public DocumentModel.Drawing.INonVisualGroupShapeProperties? NonVisualGroupShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Visual Group Shape Properties.
  /// </summary>
  public IVisualGroupShapeProperties? VisualGroupShapeProperties
  {
    get;
    set;
  }
  
}
