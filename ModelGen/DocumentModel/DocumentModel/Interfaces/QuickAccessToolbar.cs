namespace DocumentModel;

/// <summary>
/// Defines the QuickAccessToolbar Class.
/// </summary>
public partial interface QuickAccessToolbar
{
  /// <summary>
  /// SharedControlsQatItems.
  /// </summary>
  public DocumentModel.SharedControlsQatItems? SharedControlsQatItems { get; set; }
  
  /// <summary>
  /// DocumentControlsQatItems.
  /// </summary>
  public DocumentModel.DocumentControlsQatItems? DocumentControlsQatItems { get; set; }
  
}
