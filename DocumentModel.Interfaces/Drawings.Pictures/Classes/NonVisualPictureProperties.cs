namespace DocumentModel.Drawings.Pictures;

/// <summary>
///   Non-Visual Picture Properties.
/// </summary>
public interface NonVisualPictureProperties: IModelElement
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