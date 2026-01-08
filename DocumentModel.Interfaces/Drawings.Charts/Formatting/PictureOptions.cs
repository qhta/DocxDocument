namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents picture formatting options for chart elements.
///   This interface allows configuration of how pictures are applied to different parts of a chart, as well as the format and stacking behavior of the images.
/// </summary>
public interface PictureOptions
{
  /// <summary>
  ///   Indicates whether the picture is applied to the front faces of the chart element.
  /// </summary>
  public bool? ApplyToFront { get; set; }

  /// <summary>
  ///   Indicates whether the picture is applied to the side faces of the chart element.
  /// </summary>
  public bool? ApplyToSides { get; set; }

  /// <summary>
  ///   Indicates whether the picture is applied to the end faces of the chart element.
  /// </summary>
  public bool? ApplyToEnd { get; set; }

  /// <summary>
  ///   Specifies the format in which the picture is rendered on the chart element.
  /// </summary>
  public PictureFormatKind? PictureFormat { get; set; }

  /// <summary>
  ///   Defines the unit value for stacking pictures, controlling how images are repeated or stretched along the chart element.
  /// </summary>
  public Double? PictureStackUnit { get; set; }
}