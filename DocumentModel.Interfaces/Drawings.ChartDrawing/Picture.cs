namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes a picture element in chart drawings, including macro references, publishing options, non-visual properties, fill formatting, shape formatting, and style settings.
/// </summary>
public interface Picture
{
  /// <summary>
  /// Macro name or reference for custom functionality associated with the picture.
  /// </summary>
  public string? Macro { get; set; }

  /// <summary>
  /// Indicates whether the picture should be published to a server or external destination.
  /// </summary>
  public bool? Published { get; set; }

  /// <summary>
  /// Non-visual properties for the picture, including identifiers, names, and metadata.
  /// </summary>
  public NonVisualPictureProperties? NonVisualPictureProperties { get; set; }

  /// <summary>
  /// Fill formatting for the picture, including image source, tiling, and stretching options.
  /// </summary>
  public BlipFill? BlipFill { get; set; }

  /// <summary>
  /// Shape formatting and visual properties for the picture.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  /// Style settings applied to the picture for appearance customization.
  /// </summary>
  public Style? Style { get; set; }
}