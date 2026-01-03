namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
///   Defines the RelativeWidth Class.
/// </summary>
public interface RelativeWidth: IModelElement
{
  /// <summary>
  ///   relativeFrom
  /// </summary>
  public SizeRelativeHorizontallyKind? ObjectId { get; set; }
  /// <summary>
  ///   PercentageWidth.
  /// </summary>
  public string? PercentageWidth { get; set; }
}