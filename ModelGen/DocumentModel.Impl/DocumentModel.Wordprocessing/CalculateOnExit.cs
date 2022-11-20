namespace DocumentModel.Wordprocessing;

/// <summary>
/// Recalculate Fields When Current Field Is Modified.
/// </summary>
public class CalculateOnExit: ICalculateOnExit
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
