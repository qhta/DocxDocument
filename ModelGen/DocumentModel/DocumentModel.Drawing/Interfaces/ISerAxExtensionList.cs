namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SerAxExtensionList Class.
/// </summary>
public interface ISerAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ISerAxExtension>? SerAxExtensions { get ; set; }
  
}
