namespace DocumentModel;


/// <summary>
///   Defines the Ribbon Class.
/// </summary>
public partial class Ribbon
{
  
  /// <summary>
  ///   startFromScratch, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? StartFromScratch { get; set; }
  
  
  /// <summary>
  ///   QuickAccessToolbar.
  /// </summary>
  public DM.QuickAccessToolbar? QuickAccessToolbar { get; set; }
  
  
  /// <summary>
  ///   Tabs.
  /// </summary>
  public DM.Tabs? Tabs { get; set; }
  
  
  /// <summary>
  ///   ContextualTabs.
  /// </summary>
  public DM.ContextualTabs? ContextualTabs { get; set; }
  
}
