namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes non-visual properties for a picture in chart drawings, including general drawing properties and picture-specific drawing settings.
/// </summary>
public interface NonVisualPictureProperties
{
  /// <summary>
  /// General non-visual properties for the picture, such as identifier, name, and metadata.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  /// Non-visual drawing properties specific to the picture, including resizing preferences, locking options, and extension data.
  /// </summary>
  public NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get; set; }
}