namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public interface IExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.IExtension>? Extensions { get ; set; }
  
}
