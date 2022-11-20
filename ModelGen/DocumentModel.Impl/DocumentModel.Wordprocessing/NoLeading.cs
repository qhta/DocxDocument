namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Add Leading Between Lines of Text.
/// </summary>
public class NoLeading: INoLeading
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
