namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use Simplified Rules For Table Border Conflicts.
/// </summary>
public class UseSingleBorderForContiguousCells: IUseSingleBorderForContiguousCells
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
