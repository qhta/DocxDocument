namespace DocumentModel;

/// <summary>
///   Defines the PrimaryItem Class.
/// </summary>
public interface PrimaryItem: IModelElement
{
  /// <summary>
  ///   BackstageRegularButton.
  /// </summary>
  public BackstageRegularButton? BackstageRegularButton { get; set; }
  /// <summary>
  ///   BackstagePrimaryMenu.
  /// </summary>
  public BackstagePrimaryMenu? BackstagePrimaryMenu { get; set; }
}