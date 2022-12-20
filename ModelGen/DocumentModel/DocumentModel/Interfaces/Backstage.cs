namespace DocumentModel;

/// <summary>
/// Defines the Backstage Class.
/// </summary>
public partial interface Backstage
{
  /// <summary>
  /// onShow, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnShow { get; set; }
  
  /// <summary>
  /// onHide, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnHide { get; set; }
  
  public DocumentModel.BackstageTab? BackstageTab { get; set; }
  
  public DocumentModel.BackstageFastCommandButton? BackstageFastCommandButton { get; set; }
  
}
