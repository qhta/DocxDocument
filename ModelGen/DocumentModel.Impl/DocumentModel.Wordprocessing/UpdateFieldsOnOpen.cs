namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatically Recalculate Fields on Open.
/// </summary>
public class UpdateFieldsOnOpen: IUpdateFieldsOnOpen
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
