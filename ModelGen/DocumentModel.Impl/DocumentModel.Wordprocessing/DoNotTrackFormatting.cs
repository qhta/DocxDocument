namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Track Formatting Revisions When Tracking Revisions.
/// </summary>
public class DoNotTrackFormatting: IDoNotTrackFormatting
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
