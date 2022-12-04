namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom Tab Stop.
/// </summary>
public class TabStop
{
  /// <summary>
  /// Tab Stop Type
  /// </summary>
  public TabStopKind? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  public TabStopLeaderCharKind? Leader
  {
    get;
    set;
  }
  
}
