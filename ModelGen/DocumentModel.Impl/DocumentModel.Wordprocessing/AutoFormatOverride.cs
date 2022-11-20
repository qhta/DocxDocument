namespace DocumentModel.Wordprocessing;

/// <summary>
/// Allow Automatic Formatting to Override Formatting Protection Settings.
/// </summary>
public class AutoFormatOverride: IAutoFormatOverride
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
