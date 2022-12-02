namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ScatterSerExtensionList Class.
/// </summary>
public interface IScatterSerExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IScatterSerExtension>? ScatterSerExtensions { get ; set; }
  
}
