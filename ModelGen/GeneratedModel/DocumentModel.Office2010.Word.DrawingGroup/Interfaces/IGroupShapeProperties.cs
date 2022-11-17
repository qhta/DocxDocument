namespace DocumentModel.Office2010.Word.DrawingGroup;

public interface IGroupShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public BlackWhiteMode? BlackWhiteMode { get ; set; }

  public ITransformGroup? TransformGroup { get ; set; }

}
