namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the ShowEventRecordList Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IPlayEventRecord))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IStopEventRecord))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IPauseEventRecord))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IResumeEventRecord))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.ISeekEventRecord))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.INullEventRecord))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.ITriggerEventRecord))]
public class ShowEventRecordList: IShowEventRecordList
{
  /// <summary>
  /// TriggerEventRecord.
  /// </summary>
  public ITriggerEventRecord? TriggerEventRecord
  {
    get;
    set;
  }
  
  /// <summary>
  /// PlayEventRecord.
  /// </summary>
  public IPlayEventRecord? PlayEventRecord
  {
    get;
    set;
  }
  
  /// <summary>
  /// StopEventRecord.
  /// </summary>
  public IStopEventRecord? StopEventRecord
  {
    get;
    set;
  }
  
  /// <summary>
  /// PauseEventRecord.
  /// </summary>
  public IPauseEventRecord? PauseEventRecord
  {
    get;
    set;
  }
  
  /// <summary>
  /// ResumeEventRecord.
  /// </summary>
  public IResumeEventRecord? ResumeEventRecord
  {
    get;
    set;
  }
  
  /// <summary>
  /// SeekEventRecord.
  /// </summary>
  public ISeekEventRecord? SeekEventRecord
  {
    get;
    set;
  }
  
  /// <summary>
  /// NullEventRecord.
  /// </summary>
  public INullEventRecord? NullEventRecord
  {
    get;
    set;
  }
  
}
