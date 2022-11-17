namespace DocumentModel.Office2013.WebExtension;

public interface IWebExtensionStoreReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Id { get ; set; }

  public string? Version { get ; set; }

  public string? Store { get ; set; }

  public string? StoreType { get ; set; }

  public DocumentModel.Office2013.WebExtension.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }

}
