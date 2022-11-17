namespace DocumentModel.Presentation;

public interface INonVisualPictureProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Presentation.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  public DocumentModel.Presentation.INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get ; set; }
  
  public DocumentModel.Presentation.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
}
