namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public interface IExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IExtension>? Extensions { get ; set; }
  
}
