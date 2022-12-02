namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ShowEventRecordList Class.
/// </summary>
public interface IShowEventRecordList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TriggerEventRecord.
  /// </summary>
  public ITriggerEventRecord? TriggerEventRecord { get ; set; }
  
  /// <summary>
  /// PlayEventRecord.
  /// </summary>
  public IMediaPlaybackEventRecordType? PlayEventRecord { get ; set; }
  
  /// <summary>
  /// StopEventRecord.
  /// </summary>
  public IMediaPlaybackEventRecordType? StopEventRecord { get ; set; }
  
  /// <summary>
  /// PauseEventRecord.
  /// </summary>
  public IMediaPlaybackEventRecordType? PauseEventRecord { get ; set; }
  
  /// <summary>
  /// ResumeEventRecord.
  /// </summary>
  public IMediaPlaybackEventRecordType? ResumeEventRecord { get ; set; }
  
  /// <summary>
  /// SeekEventRecord.
  /// </summary>
  public ISeekEventRecord? SeekEventRecord { get ; set; }
  
  /// <summary>
  /// NullEventRecord.
  /// </summary>
  public INullEventRecord? NullEventRecord { get ; set; }
  
  public Collection<ITriggerEventRecord>? TriggerEventRecords { get ; set; }
  
  public Collection<IMediaPlaybackEventRecordType>? PlayEventRecords { get ; set; }
  
  public Collection<IMediaPlaybackEventRecordType>? StopEventRecords { get ; set; }
  
  public Collection<IMediaPlaybackEventRecordType>? PauseEventRecords { get ; set; }
  
  public Collection<IMediaPlaybackEventRecordType>? ResumeEventRecords { get ; set; }
  
  public Collection<ISeekEventRecord>? SeekEventRecords { get ; set; }
  
  public Collection<INullEventRecord>? NullEventRecords { get ; set; }
  
}
