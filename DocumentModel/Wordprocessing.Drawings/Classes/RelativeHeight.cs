namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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