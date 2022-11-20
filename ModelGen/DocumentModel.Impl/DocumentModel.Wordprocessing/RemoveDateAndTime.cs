namespace DocumentModel.Wordprocessing;

/// <summary>
/// Remove Date and Time from Annotations.
/// </summary>
public class RemoveDateAndTime: IRemoveDateAndTime
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
