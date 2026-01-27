namespace DocumentModel.Vml;
/// <summary>
///   UI Default Colors.
/// </summary>
[OpenXmlType(typeof(DXVO.ColorMenu))]
public partial class ColorMenu : ModelElement<DXVO.ColorMenu>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMenu.Extension))]
 public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

 private ExtensionHandlingBehaviorKind? _Extension;
 /// <summary>
 ///   Default stroke color
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMenu.StrokeColor))]
 public string? StrokeColor { get => _StrokeColor; set => UpdateField(ref _StrokeColor, value, nameof(StrokeColor)); }

 private string? _StrokeColor;
 /// <summary>
 ///   Default fill color
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMenu.FillColor))]
 public string? FillColor { get => _FillColor; set => UpdateField(ref _FillColor, value, nameof(FillColor)); }

 private string? _FillColor;
 /// <summary>
 ///   Default shadow color
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMenu.ShadowColor))]
 public string? ShadowColor { get => _ShadowColor; set => UpdateField(ref _ShadowColor, value, nameof(ShadowColor)); }

 private string? _ShadowColor;
 /// <summary>
 ///   Default extrusion color
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMenu.ExtrusionColor))]
 public string? ExtrusionColor { get => _ExtrusionColor; set => UpdateField(ref _ExtrusionColor, value, nameof(ExtrusionColor)); }

 private string? _ExtrusionColor;
}