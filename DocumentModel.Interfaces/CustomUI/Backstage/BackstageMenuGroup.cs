namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackstageMenuGroup Class.
/// </summary>
public interface BackstageMenuGroup:
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   idQ
  /// </summary>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   tag
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  ///   label
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   itemSize
  /// </summary>
  public ItemSizeKind? ItemSize { get; set; }

  public BackstageMenuButton? BackstageMenuButton { get; set; }

  public BackstageMenuCheckBox? BackstageMenuCheckBox { get; set; }

  public BackstageSubMenu? BackstageSubMenu { get; set; }

  public BackstageMenuToggleButton? BackstageMenuToggleButton { get; set; }
}