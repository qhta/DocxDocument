namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Backstage Class.
/// </summary>
public interface Backstage
{
  /// <summary>
  ///   onShow
  /// </summary>
  public string? OnShow { get; set; }

  /// <summary>
  ///   onHide
  /// </summary>
  public string? OnHide { get; set; }

  public BackstageTab? BackstageTab { get; set; }

  public BackstageFastCommandButton? BackstageFastCommandButton { get; set; }
}