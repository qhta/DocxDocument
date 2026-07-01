namespace DocumentModel.WebExtensions;
/// <summary>
///   Defines the WebExtensionStoreReference Class.
/// </summary>
[OpenXmlType(typeof(DXO13WE.WebExtensionStoreReference))]
[DataContract]
[XmlRoot("WebExtensionStoreReference", Namespace = "DocumentModel.WebExtensions")]
public class WebExtensionStoreReference : ModelElement<DXO13WE.WebExtensionStoreReference>
{
 /// <summary>
 /// Specifies the store item identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.WebExtensionStoreReference.Id))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
 private string? _Id;

 /// <summary>
 /// Specifies the store item version.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.WebExtensionStoreReference.Version))]
 public string? Version { get => _Version; set => UpdateField(ref _Version, value, nameof(Version)); }
 private string? _Version;

 /// <summary>
 /// Specifies the store name.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.WebExtensionStoreReference.Store))]
 public string? Store { get => _Store; set => UpdateField(ref _Store, value, nameof(Store)); }
 private string? _Store;

 /// <summary>
 /// Specifies the store type.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.WebExtensionStoreReference.StoreType))]
 public string? StoreType { get => _StoreType; set => UpdateField(ref _StoreType, value, nameof(StoreType)); }
 private string? _StoreType;

 /// <summary>
 /// Specifies the OfficeArt extension list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.WebExtensionStoreReference.OfficeArtExtensionList))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }
 private OfficeArtExtensionList? _OfficeArtExtensionList;
}