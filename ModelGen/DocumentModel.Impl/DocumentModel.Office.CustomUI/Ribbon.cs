namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the Ribbon Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IContextualTabSets))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IOfficeMenu))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IQuickAccessToolbar))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.ITabs))]
public class Ribbon: IRibbon
{
  /// <summary>
  /// startFromScratch
  /// </summary>
  public bool? StartFromScratch
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeMenu.
  /// </summary>
  public IOfficeMenu? OfficeMenu
  {
    get;
    set;
  }
  
  /// <summary>
  /// QuickAccessToolbar.
  /// </summary>
  public DocumentModel.Office.CustomUI.IQuickAccessToolbar? QuickAccessToolbar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public DocumentModel.Office.CustomUI.ITabs? Tabs
  {
    get;
    set;
  }
  
  /// <summary>
  /// ContextualTabSets.
  /// </summary>
  public IContextualTabSets? ContextualTabSets
  {
    get;
    set;
  }
  
}
