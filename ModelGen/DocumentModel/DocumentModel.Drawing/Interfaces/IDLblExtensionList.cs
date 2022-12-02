namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DLblExtensionList Class.
/// </summary>
public interface IDLblExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IDLblExtension>? DLblExtensions { get ; set; }
  
}
