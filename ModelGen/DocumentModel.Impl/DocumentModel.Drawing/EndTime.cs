namespace DocumentModel.Drawing;

/// <summary>
/// Audio End Time.
/// </summary>
public class EndTime: IEndTime
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
