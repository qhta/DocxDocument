namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Automatic Captioning Setting.
/// </summary>
public class AutoCaption: IAutoCaption
{
  /// <summary>
  /// Identifier of Object to be Automatically Captioned
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Caption Used for Automatic Captioning
  /// </summary>
  public string? Caption
  {
    get;
    set;
  }
  
}
