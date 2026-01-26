namespace DocumentModel.Drawings;
/// <summary>
/// Represents normal background properties, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
[OpenXmlType(typeof(DXO21DL.BackgroundNormalProperties))]
public partial class BackgroundNormalProperties : ModelElement<DXO21DL.BackgroundNormalProperties>, IOfficeArtExtendableElement
{
 /// <summary>
 /// List of OfficeArt extension elements.
 /// </summary>
 [OpenXmlProperty(nameof(DXO21DL.BackgroundNormalProperties.OfficeArtExtensionList))]
 /// <summary>
 /// List of OfficeArt extension elements.
 /// </summary>
 [OpenXmlElement(typeof(DXO21DL.BackgroundNormalProperties))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}