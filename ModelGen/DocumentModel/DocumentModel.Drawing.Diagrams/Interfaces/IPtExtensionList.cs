namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Defines the PtExtensionList Class.
/// </summary>
public interface IPtExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IPtExtension>? PtExtensions { get ; set; }
  
}
