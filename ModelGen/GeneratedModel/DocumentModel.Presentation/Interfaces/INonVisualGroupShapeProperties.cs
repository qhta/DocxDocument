namespace DocumentModel.Presentation;

public interface INonVisualGroupShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Presentation.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Presentation.INonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties { get ; set; }

  public DocumentModel.Presentation.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }

}
