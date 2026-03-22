namespace DocumentModel.Drawings;
/// <summary>
/// Represents properties for a background that has been removed, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
[OpenXmlType(typeof(DXO21DL.BackgroundRemovedProperties))]
public partial class BackgroundRemovedProperties : ModelElement<DXO21DL.BackgroundRemovedProperties>, IOfficeArtExtendableElement
{
 /// <summary>
 /// List of OfficeArt extension elements.
 /// </summary>
 [OpenXmlProperty(nameof(DXO21DL.BackgroundRemovedProperties.OfficeArtExtensionList))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }
 private OfficeArtExtensionList? _OfficeArtExtensionList;
}