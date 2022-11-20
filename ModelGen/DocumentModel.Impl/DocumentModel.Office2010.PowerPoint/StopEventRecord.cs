namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the StopEventRecord Class.
/// </summary>
public class StopEventRecord: IStopEventRecord
{
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Time
  {
    get;
    set;
  }
  
  /// <summary>
  /// objId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? ObjectId
  {
    get;
    set;
  }
  
}
