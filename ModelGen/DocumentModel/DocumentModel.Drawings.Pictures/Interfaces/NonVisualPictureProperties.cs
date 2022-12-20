namespace DocumentModel.Drawings.Pictures;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public partial interface NonVisualPictureProperties
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Pictures.NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Pictures.NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get; set; }
  
}
