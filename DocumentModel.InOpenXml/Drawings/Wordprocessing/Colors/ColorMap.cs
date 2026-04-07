namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Defines the color map for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.ColorMap))]
public abstract partial class ColorMap<T> : ModelElement<T> where T : DX.OpenXmlElement
{
 /// <summary>
 /// Background 1 color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.Background1))]
 public DMD.ColorSchemes? Background1 { get => _Background1; set => UpdateField(ref _Background1, value, nameof(Background1)); }
 private DMD.ColorSchemes? _Background1;
 /// <summary>
 /// Text 1 color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.Text1))]
 public DMD.ColorSchemes? Text1 { get => _Text1; set => UpdateField(ref _Text1, value, nameof(Text1)); }
 private DMD.ColorSchemes? _Text1;
 /// <summary>
 /// Background 2 color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.Background2))]
 public DMD.ColorSchemes? Background2 { get => _Background2; set => UpdateField(ref _Background2, value, nameof(Background2)); }
 private DMD.ColorSchemes? _Background2;
 /// <summary>
 /// Text 2 color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.Text2))]
 public DMD.ColorSchemes? Text2 { get => _Text2; set => UpdateField(ref _Text2, value, nameof(Text2)); }
 private DMD.ColorSchemes? _Text2;
 /// <summary>
 /// Accent 1 color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.Accent1))]
 public DMD.ColorSchemes? Accent1 { get => _Accent1; set => UpdateField(ref _Accent1, value, nameof(Accent1)); }
 private DMD.ColorSchemes? _Accent1;
 /// <summary>
 /// Accent 2 color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.Accent2))]
 public DMD.ColorSchemes? Accent2 { get => _Accent2; set => UpdateField(ref _Accent2, value, nameof(Accent2)); }
 private DMD.ColorSchemes? _Accent2;
 /// <summary>
 /// Accent 3 color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.Accent3))]
 public DMD.ColorSchemes? Accent3 { get => _Accent3; set => UpdateField(ref _Accent3, value, nameof(Accent3)); }
 private DMD.ColorSchemes? _Accent3;
 /// <summary>
 /// Accent 4 color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.Accent4))]
 public DMD.ColorSchemes? Accent4 { get => _Accent4; set => UpdateField(ref _Accent4, value, nameof(Accent4)); }
 private DMD.ColorSchemes? _Accent4;
 /// <summary>
 /// Accent 5 color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.Accent5))]
 public DMD.ColorSchemes? Accent5 { get => _Accent5; set => UpdateField(ref _Accent5, value, nameof(Accent5)); }
 private DMD.ColorSchemes? _Accent5;
 /// <summary>
 /// Accent 6 color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.Accent6))]
 public DMD.ColorSchemes? Accent6 { get => _Accent6; set => UpdateField(ref _Accent6, value, nameof(Accent6)); }
 private DMD.ColorSchemes? _Accent6;
 /// <summary>
 /// Hyperlink color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.Hyperlink))]
 public DMD.ColorSchemes? Hyperlink { get => _Hyperlink; set => UpdateField(ref _Hyperlink, value, nameof(Hyperlink)); }
 private DMD.ColorSchemes? _Hyperlink;
 /// <summary>
 /// Followed hyperlink color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ColorMap.FollowedHyperlink))]
 public DMD.ColorSchemes? FollowedHyperlink { get => _FollowedHyperlink; set => UpdateField(ref _FollowedHyperlink, value, nameof(FollowedHyperlink)); }
 private DMD.ColorSchemes? _FollowedHyperlink;
}
/// <summary>
/// Specific DXD.ColorMap mapping type.
/// </summary>
[OpenXmlType(typeof(DXD.ColorMap))]
public class ColorMap : ColorMap<DXD.ColorMap>
{
}