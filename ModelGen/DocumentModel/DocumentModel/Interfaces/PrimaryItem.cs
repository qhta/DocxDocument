namespace DocumentModel;

/// <summary>
/// Defines the PrimaryItem Class.
/// </summary>
public partial interface PrimaryItem
{
  /// <summary>
  /// BackstageRegularButton.
  /// </summary>
  public DocumentModel.BackstageRegularButton? BackstageRegularButton { get; set; }
  
  /// <summary>
  /// BackstagePrimaryMenu.
  /// </summary>
  public DocumentModel.BackstagePrimaryMenu? BackstagePrimaryMenu { get; set; }
  
}
