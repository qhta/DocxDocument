namespace DocumentModel;

/// <summary>
/// Defines the Ribbon Class.
/// </summary>
public partial interface Ribbon
{
  /// <summary>
  /// startFromScratch, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? StartFromScratch { get; set; }
  
  /// <summary>
  /// QuickAccessToolbar.
  /// </summary>
  public DocumentModel.QuickAccessToolbar? QuickAccessToolbar { get; set; }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public DocumentModel.Tabs? Tabs { get; set; }
  
  /// <summary>
  /// ContextualTabs.
  /// </summary>
  public DocumentModel.ContextualTabs? ContextualTabs { get; set; }
  
}
