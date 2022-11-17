namespace DocumentModel.Drawing.ChartDrawing;

public interface IGroupShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public BlackWhiteMode? BlackWhiteMode { get ; set; }

  public ITransformGroup? TransformGroup { get ; set; }

}
