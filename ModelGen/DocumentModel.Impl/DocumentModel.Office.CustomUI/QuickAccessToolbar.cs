namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the QuickAccessToolbar Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.ISharedQatControls))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IDocumentSpecificQuickAccessToolbarControls))]
public class QuickAccessToolbar: IQuickAccessToolbar
{
  /// <summary>
  /// SharedQatControls.
  /// </summary>
  public ISharedQatControls? SharedQatControls
  {
    get;
    set;
  }
  
  /// <summary>
  /// DocumentSpecificQuickAccessToolbarControls.
  /// </summary>
  public IDocumentSpecificQuickAccessToolbarControls? DocumentSpecificQuickAccessToolbarControls
  {
    get;
    set;
  }
  
}
