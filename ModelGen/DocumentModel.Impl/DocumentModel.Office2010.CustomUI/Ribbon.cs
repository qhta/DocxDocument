namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the Ribbon Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IContextualTabs))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IQuickAccessToolbar))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.ITabs))]
public class Ribbon: IRibbon
{
  /// <summary>
  /// startFromScratch, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? StartFromScratch
  {
    get;
    set;
  }
  
  /// <summary>
  /// QuickAccessToolbar.
  /// </summary>
  public DocumentModel.Office2010.CustomUI.IQuickAccessToolbar? QuickAccessToolbar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public DocumentModel.Office2010.CustomUI.ITabs? Tabs
  {
    get;
    set;
  }
  
  /// <summary>
  /// ContextualTabs.
  /// </summary>
  public IContextualTabs? ContextualTabs
  {
    get;
    set;
  }
  
}
