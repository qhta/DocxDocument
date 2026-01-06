namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackstageItemType Class.
/// </summary>
public interface BackstageItemType
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   label
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel
  /// </summary>
  public string? GetLabel { get; set; }
}