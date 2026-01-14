namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the relative height settings for a drawing element in a Wordprocessing document.
/// This interface provides configuration for vertical size adjustment, including the reference point and percentage height relative to another element.
/// </summary>
public class RelativeHeight: ModelElement
{
  /// <summary>
  /// The reference point used to determine the relative vertical sizing, such as margin, page, or paragraph.
  /// </summary>
  public SizeRelativeVerticallyKind? RelativeFrom { get; set; }

  /// <summary>
  /// The percentage value specifying the height of the drawing element relative to the reference point.
  /// </summary>
  public string? PercentageHeight { get; set; }
}