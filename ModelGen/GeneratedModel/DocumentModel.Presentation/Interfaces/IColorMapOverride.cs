namespace DocumentModel.Presentation;

public interface IColorMapOverride // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IMasterColorMapping? MasterColorMapping { get ; set; }
  
  public IOverrideColorMapping? OverrideColorMapping { get ; set; }
  
}
