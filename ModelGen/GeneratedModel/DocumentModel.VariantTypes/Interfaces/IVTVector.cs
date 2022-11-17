namespace DocumentModel.VariantTypes;

public interface IVTVector // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public VectorBase? BaseType { get ; set; }
  
  public uint? Size { get ; set; }
  
}
