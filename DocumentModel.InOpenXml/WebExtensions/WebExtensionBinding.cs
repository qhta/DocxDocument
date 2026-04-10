namespace DocumentModel.WebExtensions;
/// <summary>
///   Defines the WebExtensionBinding Class.
/// </summary>
[OpenXmlType(typeof(DXO13WE.WebExtensionBinding))]
[XmlRoot("WebExtensionBinding", Namespace = "DocumentModel.WebExtensions")]
public class WebExtensionBinding : ModelElement<DXO13WE.WebExtensionBinding>
{
 /// <summary>
 /// Specifies the binding identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.WebExtensionBinding.Id))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 /// Specifies the binding type.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.WebExtensionBinding.Type))]
 public string? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private string? _Type;
 /// <summary>
 /// Specifies the application reference for the binding.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.WebExtensionBinding.AppReference))]
 public string? AppReference { get => _AppReference; set => UpdateField(ref _AppReference, value, nameof(AppReference)); }

 private string? _AppReference;
 /// <summary>
 /// Specifies the OfficeArt extension list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.WebExtensionBinding.OfficeArtExtensionList))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}