namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ShapePropertiesExtensionList Class.
/// </summary>
public interface IShapePropertiesExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IShapePropertiesExtension>? ShapePropertiesExtensions { get ; set; }
  
}
