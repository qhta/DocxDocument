namespace DocumentModel.Wordprocessing;

/// <summary>
/// Don't Justify Lines Ending in Soft Line Break.
/// </summary>
public class DoNotExpandShiftReturn: IDoNotExpandShiftReturn
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
