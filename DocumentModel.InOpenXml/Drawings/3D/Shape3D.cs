namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Defines properties for a 3-D shape, including depth, extrusion, contour, material, bevels, and color settings.
/// </summary>
[OpenXmlType(typeof(DXDD.Shape3D))]
public partial class Shape3D : ModelElement<DXDD.Shape3D>, IExtendableElement
{
 /// <summary>
 ///   Shape depth along the Z-axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Shape3D.Z))]
 public Int64? Z { get => _Z; set => UpdateField(ref _Z, value, nameof(Z)); }
 private Int64? _Z;
 /// <summary>
 ///   Height of the extrusion applied to the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Shape3D.ExtrusionHeight))]
 public Int64? ExtrusionHeight { get => _ExtrusionHeight; set => UpdateField(ref _ExtrusionHeight, value, nameof(ExtrusionHeight)); }
 private Int64? _ExtrusionHeight;
 /// <summary>
 ///   Width of the contour around the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Shape3D.ContourWidth))]
 public Int64? ContourWidth { get => _ContourWidth; set => UpdateField(ref _ContourWidth, value, nameof(ContourWidth)); }
 private Int64? _ContourWidth;
 /// <summary>
 ///   Preset material type applied to the shape's surface.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Shape3D.PresetMaterial))]
 public PresetMaterialType? PresetMaterial { get => _PresetMaterial; set => UpdateField(ref _PresetMaterial, value, nameof(PresetMaterial)); }
 private PresetMaterialType? _PresetMaterial;
 /// <summary>
 ///   Top bevel effect applied to the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Shape3D.BevelTop))]
 public Bevel? BevelTop { get => _BevelTop; set => UpdateField(ref _BevelTop, value, nameof(BevelTop)); }
 private Bevel? _BevelTop;
 /// <summary>
 ///   Bottom bevel effect applied to the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Shape3D.BevelBottom))]
 public Bevel? BevelBottom { get => _BevelBottom; set => UpdateField(ref _BevelBottom, value, nameof(BevelBottom)); }
 private Bevel? _BevelBottom;
 /// <summary>
 ///   Color used for the extrusion.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Shape3D.ExtrusionColor))]
 public ExtrusionColor? ExtrusionColor { get => _ExtrusionColor; set => UpdateField(ref _ExtrusionColor, value, nameof(ExtrusionColor)); }
 private ExtrusionColor? _ExtrusionColor;
 /// <summary>
 ///   Color used for the contour.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Shape3D.ContourColor))]
 public ContourColor? ContourColor { get => _ContourColor; set => UpdateField(ref _ContourColor, value, nameof(ContourColor)); }
 private ContourColor? _ContourColor;
 /// <summary>
 /// Gets or sets the list of extensions associated with this object.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Shape3D.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}