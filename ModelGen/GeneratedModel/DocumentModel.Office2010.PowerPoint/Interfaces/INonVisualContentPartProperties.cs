namespace DocumentModel.Office2010.PowerPoint;

public interface INonVisualContentPartProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2010.PowerPoint.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  public DocumentModel.Office2010.PowerPoint.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
  public DocumentModel.Office2010.PowerPoint.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
}
