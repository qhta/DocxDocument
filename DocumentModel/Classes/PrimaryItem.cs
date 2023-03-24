namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PrimaryItem Class.
/// </summary>
public class PrimaryItem: ModelElement
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