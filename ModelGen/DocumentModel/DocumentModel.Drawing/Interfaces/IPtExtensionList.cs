namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PtExtensionList Class.
/// </summary>
public interface IPtExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPtExtension>? PtExtensions { get ; set; }
  
}
