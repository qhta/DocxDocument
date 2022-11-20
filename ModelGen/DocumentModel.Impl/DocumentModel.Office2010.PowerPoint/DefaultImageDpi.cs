namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the DefaultImageDpi Class.
/// </summary>
public class DefaultImageDpi: IDefaultImageDpi
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Val
  {
    get;
    set;
  }
  
}
