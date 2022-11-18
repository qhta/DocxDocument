namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.ILaserTraceList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IShowEventRecordList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Comment.ICommentRelationship))]
public interface ISlideExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
