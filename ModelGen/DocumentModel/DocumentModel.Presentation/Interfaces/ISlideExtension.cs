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
  
  public DocumentModel.Presentation.ILaserTraceList? LaserTraceList { get ; set; }
  
  public DocumentModel.Presentation.IShowEventRecordList? ShowEventRecordList { get ; set; }
  
  public DocumentModel.Presentation.ICommentRelationship? CommentRelationship { get ; set; }
  
}
