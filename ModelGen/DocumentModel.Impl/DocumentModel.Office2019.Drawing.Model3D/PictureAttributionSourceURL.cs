namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Optional source attribution URL describes from whence the 3D model came..
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
