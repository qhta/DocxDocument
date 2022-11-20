namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Track Formatting Revisions When Tracking Revisions.
/// </summary>
public interface IDoNotTrackFormatting // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
