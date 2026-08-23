namespace DocumentModel.Drawings;

/// <summary>
/// Represents background blur properties, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
[OpenXmlType(typeof(DXO21DL.BackgroundBlurProperties))]
[DataContract]
[XmlRoot("BackgroundBlurProperties", Namespace = "DocumentModel.Drawings")]
public partial class BackgroundBlurProperties: ModelElement<DXO21DL.BackgroundBlurProperties>,
  IOfficeArtExtendableElement
{
  /// <summary>
  /// List of OfficeArt extension elements.
  /// </summary>
  [OpenXmlProperty(nameof(DXO21DL.BackgroundBlurProperties.OfficeArtExtensionList))]
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => _OfficeArtExtensionList ??=
      GetProperty<OfficeArtExtensionList?>(GetUpdatableElement()?.OfficeArtExtensionList);
    set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList));
  }

  private OfficeArtExtensionList? _OfficeArtExtensionList;
}