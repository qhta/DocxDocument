namespace DocumentModel.Math;

public interface IFractionProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IFractionType? FractionType { get ; set; }
  
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
