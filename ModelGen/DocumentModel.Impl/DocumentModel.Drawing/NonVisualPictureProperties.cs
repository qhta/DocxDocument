namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Properties for a Picture.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualPictureDrawingProperties))]
public class NonVisualPictureProperties: INonVisualPictureProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
  {
    get;
    set;
  }
  
}
