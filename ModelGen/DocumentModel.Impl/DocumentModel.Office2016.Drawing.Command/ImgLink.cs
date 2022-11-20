namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the ImgLink Class.
/// </summary>
public class ImgLink: IImgLink
{
  /// <summary>
  /// tgt, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Tgt
  {
    get;
    set;
  }
  
}
