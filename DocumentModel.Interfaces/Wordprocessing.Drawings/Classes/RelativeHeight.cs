namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
///   Defines the RelativeHeight Class.
/// </summary>
public interface RelativeHeight:
{
  /// <summary>
  ///   relativeFrom
  /// </summary>
  public SizeRelativeVerticallyKind? RelativeFrom { get; set; }
  /// <summary>
  ///   PercentageHeight.
  /// </summary>
  public string? PercentageHeight { get; set; }
}