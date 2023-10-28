namespace DocumentModel.CustomUI10;


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
  public DMCUI10.QuickAccessToolbar? QuickAccessToolbar { get; set; }
  
  
  /// <summary>
  ///   Tabs.
  /// </summary>
  public DMCUI10.Tabs? Tabs { get; set; }
  
  
  /// <summary>
  ///   ContextualTabs.
  /// </summary>
  public DMCUI10.ContextualTabs? ContextualTabs { get; set; }
  
}
