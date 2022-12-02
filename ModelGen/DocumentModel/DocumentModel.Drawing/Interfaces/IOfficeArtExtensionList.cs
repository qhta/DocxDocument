namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public interface IOfficeArtExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IExtension>? Extensions { get ; set; }
  
}
