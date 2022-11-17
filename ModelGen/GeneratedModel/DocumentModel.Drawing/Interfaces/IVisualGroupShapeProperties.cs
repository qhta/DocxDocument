namespace DocumentModel.Drawing;

public interface IVisualGroupShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public BlackWhiteMode? BlackWhiteMode { get ; set; }

  public ITransformGroup? TransformGroup { get ; set; }

}
