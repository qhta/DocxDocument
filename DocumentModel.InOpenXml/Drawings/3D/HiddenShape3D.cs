namespace DocumentModel.Drawings;
/// <summary>
///   Represents hidden 3D shape properties, including depth, extrusion, contour, material, bevels, and color settings.
/// </summary>
public partial class HiddenShape3D : ModelElement<DXO10D.HiddenShape3D>, IExtendableElement
{
    /// <summary>
    ///   Shape depth along the Z-axis.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.HiddenShape3D.Z))]
    /// <summary>
    ///   Shape depth along the Z-axis.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.HiddenShape3D))]
    public Int64? Z { get => _Z; set => UpdateField(ref _Z, value, nameof(Z)); }

    private Int64? _Z;
    /// <summary>
    ///   Height of the extrusion applied to the shape.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.HiddenShape3D.ExtrusionHeight))]
    /// <summary>
    ///   Height of the extrusion applied to the shape.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.HiddenShape3D))]
    public Int64? ExtrusionHeight { get => _ExtrusionHeight; set => UpdateField(ref _ExtrusionHeight, value, nameof(ExtrusionHeight)); }

    private Int64? _ExtrusionHeight;
    /// <summary>
    ///   Width of the contour around the shape.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.HiddenShape3D.ContourWidth))]
    /// <summary>
    ///   Width of the contour around the shape.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.HiddenShape3D))]
    public Int64? ContourWidth { get => _ContourWidth; set => UpdateField(ref _ContourWidth, value, nameof(ContourWidth)); }

    private Int64? _ContourWidth;
    /// <summary>
    ///   Preset material type applied to the shape's surface.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.HiddenShape3D.PresetMaterial))]
    /// <summary>
    ///   Preset material type applied to the shape's surface.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.HiddenShape3D))]
    public PresetMaterialKind? PresetMaterial { get => _PresetMaterial; set => UpdateField(ref _PresetMaterial, value, nameof(PresetMaterial)); }

    private PresetMaterialKind? _PresetMaterial;
    /// <summary>
    ///   Top bevel effect applied to the shape.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.HiddenShape3D.BevelTop))]
    /// <summary>
    ///   Top bevel effect applied to the shape.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.HiddenShape3D))]
    public BevelType? BevelTop { get => _BevelTop; set => UpdateField(ref _BevelTop, value, nameof(BevelTop)); }

    private BevelType? _BevelTop;
    /// <summary>
    ///   Bottom bevel effect applied to the shape.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.HiddenShape3D.BevelBottom))]
    /// <summary>
    ///   Bottom bevel effect applied to the shape.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.HiddenShape3D))]
    public BevelType? BevelBottom { get => _BevelBottom; set => UpdateField(ref _BevelBottom, value, nameof(BevelBottom)); }

    private BevelType? _BevelBottom;
    /// <summary>
    ///   Color used for the extrusion.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.HiddenShape3D.ExtrusionColor))]
    /// <summary>
    ///   Color used for the extrusion.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.HiddenShape3D))]
    public ExtrusionColor? ExtrusionColor { get => _ExtrusionColor; set => UpdateField(ref _ExtrusionColor, value, nameof(ExtrusionColor)); }

    private ExtrusionColor? _ExtrusionColor;
    /// <summary>
    ///   Color used for the contour.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.HiddenShape3D.ContourColor))]
    /// <summary>
    ///   Color used for the contour.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.HiddenShape3D))]
    public ContourColor? ContourColor { get => _ContourColor; set => UpdateField(ref _ContourColor, value, nameof(ContourColor)); }

    private ContourColor? _ContourColor;
    /// <summary>
    /// List of extension elements.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.HiddenShape3D.ExtensionList))]
    /// <summary>
    /// List of extension elements.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.HiddenShape3D))]
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}