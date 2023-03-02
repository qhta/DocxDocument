namespace DocumentModel.Drawings.Pictures;

/// <summary>
///   Non-Visual Picture Properties.
/// </summary>
public record NonVisualPictureProperties
{
  /// <summary>
  ///   Non-Visual Drawing Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  ///   Non-Visual Picture Drawing Properties.
  /// </summary>
  public NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get; set; }
}