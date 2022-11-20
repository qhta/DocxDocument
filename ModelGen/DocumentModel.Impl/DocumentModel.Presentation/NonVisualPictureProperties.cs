namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Properties for a Picture.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualPictureDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IApplicationNonVisualDrawingProperties))]
public class NonVisualPictureProperties: INonVisualPictureProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Presentation.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public DocumentModel.Presentation.INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Presentation.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
  {
    get;
    set;
  }
  
}
