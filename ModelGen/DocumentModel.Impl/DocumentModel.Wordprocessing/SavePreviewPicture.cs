namespace DocumentModel.Wordprocessing;

/// <summary>
/// Generate Thumbnail For Document On Save.
/// </summary>
public class SavePreviewPicture: ISavePreviewPicture
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
