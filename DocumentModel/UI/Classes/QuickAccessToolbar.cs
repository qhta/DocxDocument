namespace DocumentModel.UI;

/// <summary>
///   Defines the QuickAccessToolbar Class.
/// </summary>
public class QuickAccessToolbar: ModelElement
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