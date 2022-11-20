namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Exact Line Height for Last Line on Page.
/// </summary>
public class SuppressBottomSpacing: ISuppressBottomSpacing
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
