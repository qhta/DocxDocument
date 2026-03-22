namespace DocumentModel.WebExtensions;
/// <summary>
/// Represents a web extension that can be embedded within an Open XML document to provide additional functionality or
/// integration with web-based services.
/// </summary>
[OpenXmlType(typeof(DXO13WE.WebExtension))]
public class WebExtension: Extension
{
  /// <summary>
  /// Specifies the extension identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13WE.WebExtension.Id))]
  public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private string? _Id;
  /// <summary>
  /// Specifies whether the extension is frozen.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13WE.WebExtension.Frozen))]
  public bool? Frozen { get => _Frozen; set => UpdateField(ref _Frozen, value, nameof(Frozen)); }
  private bool? _Frozen;
  /// <summary>
  /// Specifies the store reference for the extension.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13WE.WebExtension.WebExtensionStoreReference))]
  public WebExtensionStoreReference? WebExtensionStoreReference
  {
    get => _WebExtensionStoreReference;
    set => UpdateField(ref _WebExtensionStoreReference, value, nameof(WebExtensionStoreReference));
  }
  private WebExtensionStoreReference? _WebExtensionStoreReference;
  /// <summary>
  /// Specifies the list of extension references.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13WE.WebExtension.WebExtensionReferenceList))]
  public WebExtensionReferenceList? WebExtensionReferenceList
  {
    get => _WebExtensionReferenceList;
    set => UpdateField(ref _WebExtensionReferenceList, value, nameof(WebExtensionReferenceList));
  }
  private WebExtensionReferenceList? _WebExtensionReferenceList;
  /// <summary>
  /// Specifies the custom property bag for the extension.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13WE.WebExtension.WebExtensionPropertyBag))]
  public WebExtensionPropertyBag? WebExtensionPropertyBag
  {
    get => _WebExtensionPropertyBag;
    set => UpdateField(ref _WebExtensionPropertyBag, value, nameof(WebExtensionPropertyBag));
  }
  private WebExtensionPropertyBag? _WebExtensionPropertyBag;
  /// <summary>
  /// Specifies the list of bindings for the extension.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13WE.WebExtension.WebExtensionBindingList))]
  public WebExtensionBindingList? WebExtensionBindingList
  {
    get => _WebExtensionBindingList;
    set => UpdateField(ref _WebExtensionBindingList, value, nameof(WebExtensionBindingList));
  }
  private WebExtensionBindingList? _WebExtensionBindingList;
  /// <summary>
  /// Specifies the snapshot associated with the extension.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13WE.WebExtension.Snapshot))]
  public Snapshot? Snapshot { get => _Snapshot; set => UpdateField(ref _Snapshot, value, nameof(Snapshot)); }
  private Snapshot? _Snapshot;
  /// <summary>
  /// Specifies the OfficeArt extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13WE.WebExtension.OfficeArtExtensionList))]
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => _OfficeArtExtensionList;
    set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList));
  }
  private OfficeArtExtensionList? _OfficeArtExtensionList;
}