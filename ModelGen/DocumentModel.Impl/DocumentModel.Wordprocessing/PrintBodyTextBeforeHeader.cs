namespace DocumentModel.Wordprocessing;

/// <summary>
/// Print Body Text before Header/Footer Contents.
/// </summary>
public class PrintBodyTextBeforeHeader: IPrintBodyTextBeforeHeader
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
