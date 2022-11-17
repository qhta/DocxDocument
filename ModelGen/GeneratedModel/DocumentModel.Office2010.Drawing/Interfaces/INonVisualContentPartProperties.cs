namespace DocumentModel.Office2010.Drawing;

public interface INonVisualContentPartProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2010.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Office2010.Drawing.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }

}
