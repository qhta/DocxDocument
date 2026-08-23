namespace DocumentModel.Drawings;

/// <summary>
/// Represents normal background properties, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
[OpenXmlType(typeof(DXO21DL.BackgroundNormalProperties))]
[DataContract]
[XmlRoot("BackgroundNormalProperties", Namespace = "DocumentModel.Drawings")]
public partial class BackgroundNormalProperties: ModelElement<DXO21DL.BackgroundNormalProperties>,
  IOfficeArtExtendableElement
{
  /// <summary>
  /// List of OfficeArt extension elements.
  /// </summary>
  [OpenXmlProperty(nameof(DXO21DL.BackgroundNormalProperties.OfficeArtExtensionList))]
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => _OfficeArtExtensionList ??=
      GetProperty<OfficeArtExtensionList?>(GetUpdatableElement()?.OfficeArtExtensionList);
    set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList));
  }

  private OfficeArtExtensionList? _OfficeArtExtensionList;
}