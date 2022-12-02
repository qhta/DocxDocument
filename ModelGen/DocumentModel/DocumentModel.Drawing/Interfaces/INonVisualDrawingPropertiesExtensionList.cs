namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public interface INonVisualDrawingPropertiesExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<INonVisualDrawingPropertiesExtension>? NonVisualDrawingPropertiesExtensions { get ; set; }
  
}
