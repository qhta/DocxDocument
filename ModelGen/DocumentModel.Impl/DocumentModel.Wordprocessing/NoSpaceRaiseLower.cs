namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Increase Line Height for Raised/Lowered Text.
/// </summary>
public class NoSpaceRaiseLower: INoSpaceRaiseLower
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
