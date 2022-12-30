namespace DocumentModel.UI;

/// <summary>
/// Defines the QuickAccessToolbar Class.
/// </summary>
public partial class QuickAccessToolbar
{
  /// <summary>
  /// SharedQatControls.
  /// </summary>
  public DocumentModel.UI.SharedQatControls? SharedQatControls { get; set; }
  
  /// <summary>
  /// DocumentSpecificQuickAccessToolbarControls.
  /// </summary>
  public DocumentModel.UI.DocumentSpecificQuickAccessToolbarControls? DocumentSpecificQuickAccessToolbarControls { get; set; }
  
}
