namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Automatically Compress Images.
/// </summary>
public class DoNotAutoCompressPictures: IDoNotAutoCompressPictures
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
