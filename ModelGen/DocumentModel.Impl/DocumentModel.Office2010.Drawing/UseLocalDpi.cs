namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the UseLocalDpi Class.
/// </summary>
public class UseLocalDpi: IUseLocalDpi
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
