namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Minimum and Exact Line Height for First Line on Page.
/// </summary>
public class SuppressTopSpacing: ISuppressTopSpacing
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
