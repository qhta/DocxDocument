namespace DocumentModel.Presentation;

public interface INonVisualShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Presentation.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  public DocumentModel.Presentation.INonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
  public DocumentModel.Presentation.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
}
