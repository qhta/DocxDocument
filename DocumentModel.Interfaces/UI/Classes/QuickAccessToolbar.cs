namespace DocumentModel.UI;

/// <summary>
///   Defines the QuickAccessToolbar Class.
/// </summary>
public interface QuickAccessToolbar:
{
  /// <summary>
  ///   SharedQatControls.
  /// </summary>
  public SharedQatControls? SharedQatControls { get; set; }
  /// <summary>
  ///   DocumentSpecificQuickAccessToolbarControls.
  /// </summary>
  public DocumentSpecificQuickAccessToolbarControls? DocumentSpecificQuickAccessToolbarControls { get; set; }
}