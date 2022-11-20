namespace DocumentModel.Wordprocessing;

/// <summary>
/// Print Two Pages Per Sheet.
/// </summary>
public class PrintTwoOnOne: IPrintTwoOnOne
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
