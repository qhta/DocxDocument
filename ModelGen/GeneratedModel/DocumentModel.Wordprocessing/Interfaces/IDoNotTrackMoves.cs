namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Use Move Syntax When Tracking Revisions.
/// </summary>
public interface IDoNotTrackMoves // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
