namespace DocumentModel.Vml;
/// <summary>
///   UI Default Colors.
/// </summary>
[OpenXmlType(typeof(DXVO.ColorMenu))]
[DataContract]
[XmlRoot("ColorMenu", Namespace = "DocumentModel.Vml")]
public partial class ColorMenu : ModelElement<DXVO.ColorMenu>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMenu.Extension))]
 public ExtensionHandlingBehavior? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }
 private ExtensionHandlingBehavior? _Extension;

 /// <summary>
 ///   Default stroke color
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMenu.StrokeColor))]
 public VmlColor? StrokeColor { get => _StrokeColor; set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor)); }
 private VmlColor? _StrokeColor;

 /// <summary>
 ///   Default fill color
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMenu.FillColor))]
 public VmlColor? FillColor { get => _FillColor; set => UpdateField(ref _FillColor, value, nameof(FillColor)); }
 private VmlColor? _FillColor;

 /// <summary>
 ///   Default shadow color
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMenu.ShadowColor))]
 public VmlColor? ShadowColor { get => _ShadowColor; set => UpdateField(ref _ShadowColor, value, nameof(ShadowColor)); }
 private VmlColor? _ShadowColor;

 /// <summary>
 ///   Default extrusion color
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMenu.ExtrusionColor))]
 public VmlColor? ExtrusionColor { get => _ExtrusionColor; set => UpdateField(ref _ExtrusionColor, value, nameof(ExtrusionColor)); }
 private VmlColor? _ExtrusionColor;
}