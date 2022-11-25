namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the ShowEventRecordList Class.
/// </summary>
public interface IShowEventRecordList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TriggerEventRecord.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.ITriggerEventRecord? TriggerEventRecord { get ; set; }
  
  /// <summary>
  /// PlayEventRecord.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.IMediaPlaybackEventRecordType? PlayEventRecord { get ; set; }
  
  /// <summary>
  /// StopEventRecord.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.IMediaPlaybackEventRecordType? StopEventRecord { get ; set; }
  
  /// <summary>
  /// PauseEventRecord.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.IMediaPlaybackEventRecordType? PauseEventRecord { get ; set; }
  
  /// <summary>
  /// ResumeEventRecord.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.IMediaPlaybackEventRecordType? ResumeEventRecord { get ; set; }
  
  /// <summary>
  /// SeekEventRecord.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.ISeekEventRecord? SeekEventRecord { get ; set; }
  
  /// <summary>
  /// NullEventRecord.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.INullEventRecord? NullEventRecord { get ; set; }
  
}
