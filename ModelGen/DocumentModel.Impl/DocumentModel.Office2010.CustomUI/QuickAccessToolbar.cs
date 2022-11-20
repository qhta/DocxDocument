namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the QuickAccessToolbar Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ISharedControlsQatItems))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IDocumentControlsQatItems))]
public class QuickAccessToolbar: IQuickAccessToolbar
{
  /// <summary>
  /// SharedControlsQatItems.
  /// </summary>
  public ISharedControlsQatItems? SharedControlsQatItems
  {
    get;
    set;
  }
  
  /// <summary>
  /// DocumentControlsQatItems.
  /// </summary>
  public IDocumentControlsQatItems? DocumentControlsQatItems
  {
    get;
    set;
  }
  
}
