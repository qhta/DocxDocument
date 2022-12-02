namespace DocumentModel;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public interface IOfficeArtExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<DocumentModel.Drawing.IExtension>? Extensions { get ; set; }
  
}
