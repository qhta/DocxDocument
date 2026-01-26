namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents theme color mappings for a Wordprocessing document.
/// This class provides properties for mapping theme color roles (such as background, text, accent, and hyperlink colors) to specific color scheme indexes, enabling flexible and consistent color theming throughout the document.
/// </summary>
[OpenXmlType(typeof(DXW.ColorSchemeMapping))]
public partial class ColorSchemeMapping : ModelElement<DXW.ColorSchemeMapping>
{
 /// <summary>
 /// Background 1 theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.Background1))]
 /// <summary>
 /// Background 1 theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? Background1 { get => _Background1; set => UpdateField(ref _Background1, value, nameof(Background1)); }

 private ColorSchemeIndexKind? _Background1;
 /// <summary>
 /// Text 1 theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.Text1))]
 /// <summary>
 /// Text 1 theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? Text1 { get => _Text1; set => UpdateField(ref _Text1, value, nameof(Text1)); }

 private ColorSchemeIndexKind? _Text1;
 /// <summary>
 /// Background 2 theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.Background2))]
 /// <summary>
 /// Background 2 theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? Background2 { get => _Background2; set => UpdateField(ref _Background2, value, nameof(Background2)); }

 private ColorSchemeIndexKind? _Background2;
 /// <summary>
 /// Text 2 theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.Text2))]
 /// <summary>
 /// Text 2 theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? Text2 { get => _Text2; set => UpdateField(ref _Text2, value, nameof(Text2)); }

 private ColorSchemeIndexKind? _Text2;
 /// <summary>
 /// Accent 1 theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.Accent1))]
 /// <summary>
 /// Accent 1 theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? Accent1 { get => _Accent1; set => UpdateField(ref _Accent1, value, nameof(Accent1)); }

 private ColorSchemeIndexKind? _Accent1;
 /// <summary>
 /// Accent 2 theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.Accent2))]
 /// <summary>
 /// Accent 2 theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? Accent2 { get => _Accent2; set => UpdateField(ref _Accent2, value, nameof(Accent2)); }

 private ColorSchemeIndexKind? _Accent2;
 /// <summary>
 /// Accent 3 theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.Accent3))]
 /// <summary>
 /// Accent 3 theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? Accent3 { get => _Accent3; set => UpdateField(ref _Accent3, value, nameof(Accent3)); }

 private ColorSchemeIndexKind? _Accent3;
 /// <summary>
 /// Accent 4 theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.Accent4))]
 /// <summary>
 /// Accent 4 theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? Accent4 { get => _Accent4; set => UpdateField(ref _Accent4, value, nameof(Accent4)); }

 private ColorSchemeIndexKind? _Accent4;
 /// <summary>
 /// Accent 5 theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.Accent5))]
 /// <summary>
 /// Accent 5 theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? Accent5 { get => _Accent5; set => UpdateField(ref _Accent5, value, nameof(Accent5)); }

 private ColorSchemeIndexKind? _Accent5;
 /// <summary>
 /// Accent 6 theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.Accent6))]
 /// <summary>
 /// Accent 6 theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? Accent6 { get => _Accent6; set => UpdateField(ref _Accent6, value, nameof(Accent6)); }

 private ColorSchemeIndexKind? _Accent6;
 /// <summary>
 /// Hyperlink theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.Hyperlink))]
 /// <summary>
 /// Hyperlink theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? Hyperlink { get => _Hyperlink; set => UpdateField(ref _Hyperlink, value, nameof(Hyperlink)); }

 private ColorSchemeIndexKind? _Hyperlink;
 /// <summary>
 /// Followed hyperlink theme color mapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ColorSchemeMapping.FollowedHyperlink))]
 /// <summary>
 /// Followed hyperlink theme color mapping.
 /// </summary>
 [OpenXmlElement(typeof(DXW.ColorSchemeMapping))]
 public ColorSchemeIndexKind? FollowedHyperlink { get => _FollowedHyperlink; set => UpdateField(ref _FollowedHyperlink, value, nameof(FollowedHyperlink)); }

 private ColorSchemeIndexKind? _FollowedHyperlink;
}