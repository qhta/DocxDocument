namespace DocumentModel.Office2019.Drawing;

/// <summary>
/// Defines the PictureAttributionSourceURL Class.
/// </summary>
public class PictureAttributionSourceURL: IPictureAttributionSourceURL
{
  /// <summary>
  /// id, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
