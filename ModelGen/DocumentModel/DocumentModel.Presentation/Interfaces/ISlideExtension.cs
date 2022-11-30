namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideExtension Class.
/// </summary>
public interface ISlideExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2010.PowerPoint.ILaserTraceList? LaserTraceList { get ; set; }
  
  public DocumentModel.Office2010.PowerPoint.IShowEventRecordList? ShowEventRecordList { get ; set; }
  
  public DocumentModel.Office2021.PowerPoint.Comment.ICommentRelationship? CommentRelationship { get ; set; }
  
}
