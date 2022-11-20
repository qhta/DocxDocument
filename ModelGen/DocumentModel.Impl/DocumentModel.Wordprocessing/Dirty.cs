namespace DocumentModel.Wordprocessing;

/// <summary>
/// Invalidated Field Cache.
/// </summary>
public class Dirty: IDirty
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
