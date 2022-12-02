namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideExtension Class.
/// </summary>
public interface ISlideExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ILaserTraceList? LaserTraceList { get ; set; }
  
  public IShowEventRecordList? ShowEventRecordList { get ; set; }
  
  public ICommentRelationship? CommentRelationship { get ; set; }
  
}
