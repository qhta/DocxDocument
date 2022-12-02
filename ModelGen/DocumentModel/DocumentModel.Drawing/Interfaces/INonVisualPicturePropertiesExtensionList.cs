namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public interface INonVisualPicturePropertiesExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<INonVisualPicturePropertiesExtension>? NonVisualPicturePropertiesExtensions { get ; set; }
  
}
