namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
///   Defines the RelativeHeight Class.
/// </summary>
public class RelativeHeight: ModelElement
{
  /// <summary>
  ///   relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public SizeRelativeVerticallyKind? RelativeFrom { get; set; }
  /// <summary>
  ///   PercentageHeight.
  /// </summary>
  public string? PercentageHeight { get; set; }
}