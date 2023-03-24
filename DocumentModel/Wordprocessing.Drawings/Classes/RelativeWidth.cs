namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  public String? PercentageWidth { get; set; }
}