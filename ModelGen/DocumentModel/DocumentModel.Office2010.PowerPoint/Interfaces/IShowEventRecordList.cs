namespace DocumentModel.Office2010.PowerPoint;

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
  public IPlayEventRecord? PlayEventRecord { get ; set; }
  
  /// <summary>
  /// StopEventRecord.
  /// </summary>
  public IStopEventRecord? StopEventRecord { get ; set; }
  
  /// <summary>
  /// PauseEventRecord.
  /// </summary>
  public IPauseEventRecord? PauseEventRecord { get ; set; }
  
  /// <summary>
  /// ResumeEventRecord.
  /// </summary>
  public IResumeEventRecord? ResumeEventRecord { get ; set; }
  
  /// <summary>
  /// SeekEventRecord.
  /// </summary>
  public ISeekEventRecord? SeekEventRecord { get ; set; }
  
  /// <summary>
  /// NullEventRecord.
  /// </summary>
  public INullEventRecord? NullEventRecord { get ; set; }
  
}
