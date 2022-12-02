namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ShowEventRecordList Class.
/// </summary>
public interface IShowEventRecordList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TriggerEventRecord.
  /// </summary>
  public DocumentModel.Presentation.ITriggerEventRecord? TriggerEventRecord { get ; set; }
  
  /// <summary>
  /// PlayEventRecord.
  /// </summary>
  public DocumentModel.Presentation.IMediaPlaybackEventRecordType? PlayEventRecord { get ; set; }
  
  /// <summary>
  /// StopEventRecord.
  /// </summary>
  public DocumentModel.Presentation.IMediaPlaybackEventRecordType? StopEventRecord { get ; set; }
  
  /// <summary>
  /// PauseEventRecord.
  /// </summary>
  public DocumentModel.Presentation.IMediaPlaybackEventRecordType? PauseEventRecord { get ; set; }
  
  /// <summary>
  /// ResumeEventRecord.
  /// </summary>
  public DocumentModel.Presentation.IMediaPlaybackEventRecordType? ResumeEventRecord { get ; set; }
  
  /// <summary>
  /// SeekEventRecord.
  /// </summary>
  public DocumentModel.Presentation.ISeekEventRecord? SeekEventRecord { get ; set; }
  
  /// <summary>
  /// NullEventRecord.
  /// </summary>
  public DocumentModel.Presentation.INullEventRecord? NullEventRecord { get ; set; }
  
}
