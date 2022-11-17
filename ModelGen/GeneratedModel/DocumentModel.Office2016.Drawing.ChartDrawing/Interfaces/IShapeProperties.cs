namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  public DocumentModel.Drawing.ITransform2D? Transform2D { get ; set; }
  
}
