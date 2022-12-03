namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideExtension Class.
/// </summary>
public interface SlideExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public LaserTraceList? LaserTraceList { get ; set; }
  
  public ShowEventRecordList? ShowEventRecordList { get ; set; }
  
  public CommentRelationship? CommentRelationship { get ; set; }
  
}
