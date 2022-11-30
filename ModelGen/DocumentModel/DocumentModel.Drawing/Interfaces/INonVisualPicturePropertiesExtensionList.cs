namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public interface INonVisualPicturePropertiesExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.INonVisualPicturePropertiesExtension>? NonVisualPicturePropertiesExtensions { get ; set; }
  
}
