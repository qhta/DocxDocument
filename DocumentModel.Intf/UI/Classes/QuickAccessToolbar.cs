namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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