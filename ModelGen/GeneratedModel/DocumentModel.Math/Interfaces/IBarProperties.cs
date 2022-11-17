namespace DocumentModel.Math;

public interface IBarProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Math.IPosition? Position { get ; set; }
  
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
