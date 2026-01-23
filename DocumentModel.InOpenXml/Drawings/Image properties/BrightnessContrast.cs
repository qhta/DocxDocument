namespace DocumentModel.Drawings;
/// <summary>
/// Represents brightness and contrast adjustment settings for a drawing element.
/// </summary>
public partial class BrightnessContrast : ModelElement<DXO10D.BrightnessContrast>, IExtendableElement
{
    /// <summary>
    /// Brightness adjustment value.
    /// </summary>
    public Int32? Bright { get => _Bright; set => UpdateField(ref _Bright, value, nameof(Bright)); }

    private Int32? _Bright;
    /// <summary>
    /// Contrast adjustment value.
    /// </summary>
    public Int32? Contrast { get => _Contrast; set => UpdateField(ref _Contrast, value, nameof(Contrast)); }

    private Int32? _Contrast;
    /// <summary>
    /// List of extensions for additional brightness and contrast settings.
    /// </summary>
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}