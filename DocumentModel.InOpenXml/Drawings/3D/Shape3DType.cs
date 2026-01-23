namespace DocumentModel.Drawings;
/// <summary>
///   Apply 3D shape properties.
/// </summary>
public partial class Shape3DType : ModelElement<DXD.Shape3DType>, IExtendableElement
{
    /// <summary>
    ///   Shape Depth
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Shape3DType.Z))]
    public Int64? Z { get => _Z; set => UpdateField(ref _Z, value, nameof(Z)); }

    private Int64? _Z;
    /// <summary>
    ///   Extrusion Height
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Shape3DType.ExtrusionHeight))]
    public Int64? ExtrusionHeight { get => _ExtrusionHeight; set => UpdateField(ref _ExtrusionHeight, value, nameof(ExtrusionHeight)); }

    private Int64? _ExtrusionHeight;
    /// <summary>
    ///   Contour Width
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Shape3DType.ContourWidth))]
    public Int64? ContourWidth { get => _ContourWidth; set => UpdateField(ref _ContourWidth, value, nameof(ContourWidth)); }

    private Int64? _ContourWidth;
    /// <summary>
    ///   Preset Material Type
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Shape3DType.PresetMaterial))]
    public PresetMaterialKind? PresetMaterial { get => _PresetMaterial; set => UpdateField(ref _PresetMaterial, value, nameof(PresetMaterial)); }

    private PresetMaterialKind? _PresetMaterial;
    /// <summary>
    ///   Top Bevel.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Shape3DType.BevelTop))]
    public BevelType? BevelTop { get => _BevelTop; set => UpdateField(ref _BevelTop, value, nameof(BevelTop)); }

    private BevelType? _BevelTop;
    /// <summary>
    ///   Bottom Bevel.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Shape3DType.BevelBottom))]
    public BevelType? BevelBottom { get => _BevelBottom; set => UpdateField(ref _BevelBottom, value, nameof(BevelBottom)); }

    private BevelType? _BevelBottom;
    /// <summary>
    ///   Extrusion Color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Shape3DType.ExtrusionColor))]
    public ExtrusionColor? ExtrusionColor { get => _ExtrusionColor; set => UpdateField(ref _ExtrusionColor, value, nameof(ExtrusionColor)); }

    private ExtrusionColor? _ExtrusionColor;
    /// <summary>
    ///   Contour Color.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Shape3DType.ContourColor))]
    public ContourColor? ContourColor { get => _ContourColor; set => UpdateField(ref _ContourColor, value, nameof(ContourColor)); }

    private ContourColor? _ContourColor;
    /// <summary>
    /// List of extension elements.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Shape3DType.ExtensionList))]
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}