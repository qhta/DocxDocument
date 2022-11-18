namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Properties for a Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INonVisualShapeDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IApplicationNonVisualDrawingProperties))]
public interface INonVisualShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Presentation.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Drawing Properties for a Shape.
  /// </summary>
  public DocumentModel.Presentation.INonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
  /// <summary>
  /// Application Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Presentation.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
}
