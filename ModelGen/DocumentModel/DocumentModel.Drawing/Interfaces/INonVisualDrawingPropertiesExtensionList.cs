namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public interface INonVisualDrawingPropertiesExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.INonVisualDrawingPropertiesExtension>? NonVisualDrawingPropertiesExtensions { get ; set; }
  
}
