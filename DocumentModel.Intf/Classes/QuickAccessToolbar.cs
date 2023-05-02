namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the QuickAccessToolbar Class.
/// </summary>
public class QuickAccessToolbar: ModelElement
{
  /// <summary>
  ///   SharedControlsQatItems.
  /// </summary>
  public SharedControlsQatItems? SharedControlsQatItems { get; set; }

  /// <summary>
  ///   DocumentControlsQatItems.
  /// </summary>
  public DocumentControlsQatItems? DocumentControlsQatItems { get; set; }
}