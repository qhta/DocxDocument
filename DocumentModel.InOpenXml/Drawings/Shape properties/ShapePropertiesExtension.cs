namespace DocumentModel.Drawings;
/// <summary>
///   Represents an extension for shape properties, providing additional or hidden formatting and configuration options.
/// </summary>
public partial class ShapePropertiesExtension : ModelElement<DXD.ShapePropertiesExtension>, IExtension
{
    /// <summary>
    ///   Hidden fill formatting properties.
    /// </summary>
    public Fill? HiddenFillProperties { get => _HiddenFillProperties; set => UpdateField(ref _HiddenFillProperties, value, nameof(HiddenFillProperties)); }

    private Fill? _HiddenFillProperties;
    /// <summary>
    ///   Hidden line formatting properties.
    /// </summary>
    public HiddenLineProperties? HiddenLineProperties { get => _HiddenLineProperties; set => UpdateField(ref _HiddenLineProperties, value, nameof(HiddenLineProperties)); }

    private HiddenLineProperties? _HiddenLineProperties;
    /// <summary>
    ///   Hidden effects formatting properties.
    /// </summary>
    public HiddenEffectsProperties? HiddenEffectsProperties { get => _HiddenEffectsProperties; set => UpdateField(ref _HiddenEffectsProperties, value, nameof(HiddenEffectsProperties)); }

    private HiddenEffectsProperties? _HiddenEffectsProperties;
    /// <summary>
    ///   Hidden 3D scene properties.
    /// </summary>
    public HiddenScene3D? HiddenScene3D { get => _HiddenScene3D; set => UpdateField(ref _HiddenScene3D, value, nameof(HiddenScene3D)); }

    private HiddenScene3D? _HiddenScene3D;
    /// <summary>
    ///   Hidden 3D shape properties.
    /// </summary>
    public HiddenShape3D? HiddenShape3D { get => _HiddenShape3D; set => UpdateField(ref _HiddenShape3D, value, nameof(HiddenShape3D)); }

    private HiddenShape3D? _HiddenShape3D;
    /// <summary>
    ///   Indicates whether the shadow is obscured.
    /// </summary>
    public bool? ShadowObscured { get => _ShadowObscured; set => UpdateField(ref _ShadowObscured, value, nameof(ShadowObscured)); }

    private bool? _ShadowObscured;
    /// <summary>
    /// Gets or sets the URI associated with the resource.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ShapePropertiesExtension.Uri))]
    public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

    private string? _Uri;
}