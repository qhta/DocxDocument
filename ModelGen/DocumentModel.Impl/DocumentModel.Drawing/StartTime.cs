namespace DocumentModel.Drawing;

/// <summary>
/// Audio Start Time.
/// </summary>
public class StartTime: IStartTime
{
  /// <summary>
  /// Track
  /// </summary>
  public byte? Track
  {
    get;
    set;
  }
  
  /// <summary>
  /// Time
  /// </summary>
  public uint? Time
  {
    get;
    set;
  }
  
}
