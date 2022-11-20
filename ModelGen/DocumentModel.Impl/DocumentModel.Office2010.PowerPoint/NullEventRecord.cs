namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the NullEventRecord Class.
/// </summary>
public class NullEventRecord: INullEventRecord
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
