namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the PlayEventRecord Class.
/// </summary>
public interface IPlayEventRecord // : DocumentFormat.OpenXml.Office2010.PowerPoint.MediaPlaybackEventRecordType
{
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Time { get ; set; }
  
  /// <summary>
  /// objId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? ObjectId { get ; set; }
  
}
