namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes a picture element in chart drawings, including macro references, publishing options, non-visual properties, fill formatting, shape formatting, and style settings.
/// </summary>
public interface Picture: Drawings.Pictures.Picture
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
  /// Style settings applied to the picture for appearance customization.
  /// </summary>
  public Style? Style { get; set; }
}