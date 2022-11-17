namespace DocumentModel.VariantTypes;

public interface IVTArray // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? LowerBounds { get ; set; }

  public int? UpperBounds { get ; set; }

  public ArrayBase? BaseType { get ; set; }

}
