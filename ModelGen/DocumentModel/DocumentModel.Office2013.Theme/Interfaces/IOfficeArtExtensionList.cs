namespace DocumentModel.Office2013.Theme;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public interface IOfficeArtExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IExtension>? Extensions { get ; set; }
  
}
