namespace DocumentModel.Office2021.Drawing.Livefeed;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public interface IOfficeArtExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IExtension>? Extensions { get ; set; }
  
}
