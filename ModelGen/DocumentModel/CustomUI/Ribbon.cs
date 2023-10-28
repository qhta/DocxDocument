namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the Ribbon Class.
/// </summary>
public partial class Ribbon
{
  
  /// <summary>
  ///   startFromScratch
  /// </summary>
  public Boolean? StartFromScratch { get; set; }
  
  
  /// <summary>
  ///   OfficeMenu.
  /// </summary>
  public DMCUI.OfficeMenu? OfficeMenu { get; set; }
  
  
  /// <summary>
  ///   QuickAccessToolbar.
  /// </summary>
  public DMCUI.QuickAccessToolbar? QuickAccessToolbar { get; set; }
  
  
  /// <summary>
  ///   Tabs.
  /// </summary>
  public DMCUI.Tabs? Tabs { get; set; }
  
  
  /// <summary>
  ///   ContextualTabSets.
  /// </summary>
  public DMCUI.ContextualTabSets? ContextualTabSets { get; set; }
  
}
