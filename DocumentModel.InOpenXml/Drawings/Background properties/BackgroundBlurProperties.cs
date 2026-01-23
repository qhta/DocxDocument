namespace DocumentModel.Drawings;
/// <summary>
/// Represents background blur properties, including an optional list of OfficeArt extensions for additional customization.
/// </summary>
public partial class BackgroundBlurProperties : ModelElement<DXO21DL.BackgroundBlurProperties>, IOfficeArtExtendableElement
{
    /// <summary>
    /// List of OfficeArt extension elements.
    /// </summary>
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}