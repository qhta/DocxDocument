namespace DocumentModel.Drawing.Diagrams;

public interface ITextProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IShape3DType? Shape3DType { get ; set; }
  
  public IFlatText? FlatText { get ; set; }
  
}
