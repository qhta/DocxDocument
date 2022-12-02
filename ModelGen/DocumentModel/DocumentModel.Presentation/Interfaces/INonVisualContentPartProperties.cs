namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public interface INonVisualContentPartProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Presentation.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Presentation.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Presentation.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
}
