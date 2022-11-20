namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Automatically Apply List Paragraph Style To Bulleted/Numbered Text.
/// </summary>
public class UseNormalStyleForList: IUseNormalStyleForList
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
