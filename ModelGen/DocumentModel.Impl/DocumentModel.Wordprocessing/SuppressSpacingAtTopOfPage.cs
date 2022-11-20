namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Minimum Line Height for First Line on Page.
/// </summary>
public class SuppressSpacingAtTopOfPage: ISuppressSpacingAtTopOfPage
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
