namespace DocumentModel.Wordprocessing;

/// <summary>
/// Checkbox Form Field State.
/// </summary>
public class Checked: IChecked
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
