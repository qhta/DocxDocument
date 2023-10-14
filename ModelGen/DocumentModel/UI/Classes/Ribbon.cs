namespace DocumentModel.UI;


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
  public DMUI.OfficeMenu? OfficeMenu { get; set; }
  
  
  /// <summary>
  ///   QuickAccessToolbar.
  /// </summary>
  public DMUI.QuickAccessToolbar? QuickAccessToolbar { get; set; }
  
  
  /// <summary>
  ///   Tabs.
  /// </summary>
  public DMUI.Tabs? Tabs { get; set; }
  
  
  /// <summary>
  ///   ContextualTabSets.
  /// </summary>
  public DMUI.ContextualTabSets? ContextualTabSets { get; set; }
  
}
