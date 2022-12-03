namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ShowEventRecordList Class.
/// </summary>
public interface ShowEventRecordList // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// TriggerEventRecord.
  /// </summary>
  public TriggerEventRecord? TriggerEventRecord { get ; set; }
  
  /// <summary>
  /// PlayEventRecord.
  /// </summary>
  public MediaPlaybackEventRecordType? PlayEventRecord { get ; set; }
  
  /// <summary>
  /// StopEventRecord.
  /// </summary>
  public MediaPlaybackEventRecordType? StopEventRecord { get ; set; }
  
  /// <summary>
  /// PauseEventRecord.
  /// </summary>
  public MediaPlaybackEventRecordType? PauseEventRecord { get ; set; }
  
  /// <summary>
  /// ResumeEventRecord.
  /// </summary>
  public MediaPlaybackEventRecordType? ResumeEventRecord { get ; set; }
  
  /// <summary>
  /// SeekEventRecord.
  /// </summary>
  public SeekEventRecord? SeekEventRecord { get ; set; }
  
  /// <summary>
  /// NullEventRecord.
  /// </summary>
  public NullEventRecord? NullEventRecord { get ; set; }
  
  public Collection<TriggerEventRecord>? TriggerEventRecords { get ; set; }
  
  public Collection<MediaPlaybackEventRecordType>? PlayEventRecords { get ; set; }
  
  public Collection<MediaPlaybackEventRecordType>? StopEventRecords { get ; set; }
  
  public Collection<MediaPlaybackEventRecordType>? PauseEventRecords { get ; set; }
  
  public Collection<MediaPlaybackEventRecordType>? ResumeEventRecords { get ; set; }
  
  public Collection<SeekEventRecord>? SeekEventRecords { get ; set; }
  
  public Collection<NullEventRecord>? NullEventRecords { get ; set; }
  
}
