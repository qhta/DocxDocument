namespace DocumentModel.UI;


/// <summary>
///   Defines the Ribbon Class.
/// </summary>
public partial class Ribbon
{
  
  /// <summary>
  ///   startFromScratch
  /// </summary>
  [SchemaAttr("startFromScratch")]
  public Boolean? StartFromScratch { get; set; }
  
  
  /// <summary>
  ///   OfficeMenu.
  /// </summary>
  public DocumentModel.UI.OfficeMenu? OfficeMenu { get; set; }
  
  
  /// <summary>
  ///   QuickAccessToolbar.
  /// </summary>
  public DocumentModel.UI.QuickAccessToolbar? QuickAccessToolbar { get; set; }
  
  
  /// <summary>
  ///   Tabs.
  /// </summary>
  public DocumentModel.UI.Tabs? Tabs { get; set; }
  
  
  /// <summary>
  ///   ContextualTabSets.
  /// </summary>
  public DocumentModel.UI.ContextualTabSets? ContextualTabSets { get; set; }
  
}
