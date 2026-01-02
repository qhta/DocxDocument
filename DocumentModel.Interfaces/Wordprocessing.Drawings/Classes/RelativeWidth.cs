namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
///   Defines the RelativeWidth Class.
/// </summary>
public class RelativeWidth: ModelElement
{
  /// <summary>
  ///   relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public SizeRelativeHorizontallyKind? ObjectId { get; set; }
  /// <summary>
  ///   PercentageWidth.
  /// </summary>
  public string? PercentageWidth { get; set; }
}