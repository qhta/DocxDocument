namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the Backstage Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageFastCommandButton))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageTab))]
public class Backstage: IBackstage
{
  /// <summary>
  /// onShow, this property is only available in Office 2010 and later.
  /// </summary>
  public string? OnShow
  {
    get;
    set;
  }
  
  /// <summary>
  /// onHide, this property is only available in Office 2010 and later.
  /// </summary>
  public string? OnHide
  {
    get;
    set;
  }
  
}
