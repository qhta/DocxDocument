namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the RelativeWidth Class.
/// </summary>
public class RelativeWidth: ModelElement
{
  /// <summary>
  ///   relativeFrom, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public SizeRelativeHorizontallyKind? ObjectId { get; set; }

  /// <summary>
  ///   PercentageWidth.
  /// </summary>
  public string? PercentageWidth { get; set; }
}
