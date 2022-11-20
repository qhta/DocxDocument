namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CompatibilitySetting Class.
/// </summary>
public class CompatibilitySetting: ICompatibilitySetting
{
  /// <summary>
  /// name
  /// </summary>
  public CompatSettingNameValues? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// uri
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
  /// <summary>
  /// val
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
