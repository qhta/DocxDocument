namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ShapePropertiesExtensionList Class.
/// </summary>
public interface IShapePropertiesExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IShapePropertiesExtension>? ShapePropertiesExtensions { get ; set; }
  
}
