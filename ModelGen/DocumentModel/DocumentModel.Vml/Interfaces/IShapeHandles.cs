namespace DocumentModel.Vml;

/// <summary>
/// Defines the ShapeHandles Class.
/// </summary>
public interface IShapeHandles // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IShapeHandle>? ShapeHandles { get ; set; }
  
}
