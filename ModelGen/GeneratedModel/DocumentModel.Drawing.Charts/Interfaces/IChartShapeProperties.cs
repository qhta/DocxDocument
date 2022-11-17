namespace DocumentModel.Drawing.Charts;

public interface IChartShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public BlackWhiteMode? BlackWhiteMode { get ; set; }

  public DocumentModel.Drawing.ITransform2D? Transform2D { get ; set; }

}
