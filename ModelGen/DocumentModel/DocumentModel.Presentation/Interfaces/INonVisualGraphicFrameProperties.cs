namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Properties for a Graphic Frame.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualGraphicFrameDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IApplicationNonVisualDrawingProperties))]
public interface INonVisualGraphicFrameProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Presentation.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public DocumentModel.Presentation.INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
  /// <summary>
  /// Application Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Presentation.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
}
