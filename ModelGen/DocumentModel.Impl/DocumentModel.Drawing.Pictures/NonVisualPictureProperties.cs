namespace DocumentModel.Drawing.Pictures;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Pictures.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Pictures.INonVisualPictureDrawingProperties))]
public class NonVisualPictureProperties: INonVisualPictureProperties
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.Pictures.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.Pictures.INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
  {
    get;
    set;
  }
  
}
