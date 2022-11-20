namespace DocumentModel.Wordprocessing;

/// <summary>
/// Add Additional Space Below Baseline For Underlined East Asian Text.
/// </summary>
public class SpaceForUnderline: ISpaceForUnderline
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
