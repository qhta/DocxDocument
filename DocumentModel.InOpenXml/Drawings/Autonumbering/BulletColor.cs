using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings;
/// <summary>
/// Represents a specified color for bullets, supporting multiple color models and extension options.
/// </summary>
[OpenXmlType(typeof(DXD.BulletColor))]
public partial class BulletColor : ModelElement<DXD.BulletColor>, IExtendableElement
{
 /// <summary>
 /// RGB color model using percentage values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BulletColor.RgbColorModelPercentage))]
 [OpenXmlElement(typeof(DXD.BulletColor))]
 public RgbColorModelPercentage? RgbColorModelPercentage { get => _RgbColorModelPercentage; set => UpdateField(ref _RgbColorModelPercentage, value, nameof(RgbColorModelPercentage)); }

 private RgbColorModelPercentage? _RgbColorModelPercentage;
 /// <summary>
 /// RGB color model using hexadecimal values.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BulletColor.RgbColorModelHex))]
 [OpenXmlElement(typeof(DXD.BulletColor))]
 public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

 private RgbColorModelHex? _RgbColorModelHex;
 /// <summary>
 /// HSL (Hue, Saturation, Luminance) color model.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BulletColor.HslColor))]
 [OpenXmlElement(typeof(DXD.BulletColor))]
 public HslColor? HslColor { get => _HslColor; set => UpdateField(ref _HslColor, value, nameof(HslColor)); }

 private HslColor? _HslColor;
 /// <summary>
 /// System color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BulletColor.SystemColor))]
 [OpenXmlElement(typeof(DXD.BulletColor))]
 public SystemColor? SystemColor { get => _SystemColor; set => UpdateField(ref _SystemColor, value, nameof(SystemColor)); }

 private SystemColor? _SystemColor;
 /// <summary>
 /// Scheme color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BulletColor.SchemeColor))]
 [OpenXmlElement(typeof(DXD.BulletColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
 /// <summary>
 /// Preset color.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BulletColor.PresetColor))]
 [OpenXmlElement(typeof(DXD.BulletColor))]
 public PresetColor? PresetColor { get => _PresetColor; set => UpdateField(ref _PresetColor, value, nameof(PresetColor)); }

 private PresetColor? _PresetColor;
 /// <summary>
 /// List of extensions for the bullet color.
 /// </summary>
 [OpenXmlElement(typeof(DXD.BulletColor))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}