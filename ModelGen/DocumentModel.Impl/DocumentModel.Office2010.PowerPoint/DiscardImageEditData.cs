namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the DiscardImageEditData Class.
/// </summary>
public class DiscardImageEditData: IDiscardImageEditData
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
