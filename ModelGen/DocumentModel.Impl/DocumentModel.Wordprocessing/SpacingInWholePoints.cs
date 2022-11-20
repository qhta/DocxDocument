namespace DocumentModel.Wordprocessing;

/// <summary>
/// Only Expand/Condense Text By Whole Points.
/// </summary>
public class SpacingInWholePoints: ISpacingInWholePoints
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
