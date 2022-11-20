namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Use Move Syntax When Tracking Revisions.
/// </summary>
public class DoNotTrackMoves: IDoNotTrackMoves
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
