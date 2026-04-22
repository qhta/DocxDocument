namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents the mapping between logical color roles and theme color scheme indices for a chart.
/// </summary>
/// <remarks>
///   This class defines how chart colors are mapped to the
///   document's theme color scheme, ensuring visual consistency between the chart and the overall document design.
///   The color mapping establishes relationships between semantic color roles (such as backgrounds, text colors,
///   accent colors, and hyperlinks) and specific positions in the theme's color scheme. This enables charts to
///   automatically adapt their color palette when the document theme changes, maintaining design coherence without
///   manual color adjustments. The mapping includes primary and secondary background and text colors, six accent
///   colors for data series differentiation, and hyperlink colors for interactive elements. Each mapping property
///   references a <see cref = "ColorSchemeIndexKind"/> value that identifies a position in the theme color scheme.
///   This theme-based approach promotes consistent branding and design across documents while allowing flexibility
///   through theme customization. The color mapping is referenced by the <see cref = "ChartSpace"/> to apply
///   theme colors throughout the chart's visual elements.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.ColorMappingType))]
[XmlRoot("ColorMappingType", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class ColorMappingType : ModelElement<DXO16DCD.ColorMappingType>
{
 /// <summary>
 /// Specifies the background1.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.Background1))]
 public ColorSchemeIndex? Background1 { get => _Background1; set => UpdateField(ref _Background1, value, nameof(Background1)); }
 private ColorSchemeIndex? _Background1;

 /// <summary>
 /// Specifies the text1.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.Text1))]
 public ColorSchemeIndex? Text1 { get => _Text1; set => UpdateField(ref _Text1, value, nameof(Text1)); }
 private ColorSchemeIndex? _Text1;

 /// <summary>
 /// Specifies the background2.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.Background2))]
 public ColorSchemeIndex? Background2 { get => _Background2; set => UpdateField(ref _Background2, value, nameof(Background2)); }
 private ColorSchemeIndex? _Background2;

 /// <summary>
 /// Specifies the text2.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.Text2))]
 public ColorSchemeIndex? Text2 { get => _Text2; set => UpdateField(ref _Text2, value, nameof(Text2)); }
 private ColorSchemeIndex? _Text2;

 /// <summary>
 /// Specifies the accent1.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.Accent1))]
 public ColorSchemeIndex? Accent1 { get => _Accent1; set => UpdateField(ref _Accent1, value, nameof(Accent1)); }
 private ColorSchemeIndex? _Accent1;

 /// <summary>
 /// Specifies the accent2.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.Accent2))]
 public ColorSchemeIndex? Accent2 { get => _Accent2; set => UpdateField(ref _Accent2, value, nameof(Accent2)); }
 private ColorSchemeIndex? _Accent2;

 /// <summary>
 /// Specifies the accent3.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.Accent3))]
 public ColorSchemeIndex? Accent3 { get => _Accent3; set => UpdateField(ref _Accent3, value, nameof(Accent3)); }
 private ColorSchemeIndex? _Accent3;

 /// <summary>
 /// Specifies the accent4.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.Accent4))]
 public ColorSchemeIndex? Accent4 { get => _Accent4; set => UpdateField(ref _Accent4, value, nameof(Accent4)); }
 private ColorSchemeIndex? _Accent4;

 /// <summary>
 /// Specifies the accent5.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.Accent5))]
 public ColorSchemeIndex? Accent5 { get => _Accent5; set => UpdateField(ref _Accent5, value, nameof(Accent5)); }
 private ColorSchemeIndex? _Accent5;

 /// <summary>
 /// Specifies the accent6.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.Accent6))]
 public ColorSchemeIndex? Accent6 { get => _Accent6; set => UpdateField(ref _Accent6, value, nameof(Accent6)); }
 private ColorSchemeIndex? _Accent6;

 /// <summary>
 /// Specifies the hyperlink.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.Hyperlink))]
 public ColorSchemeIndex? Hyperlink { get => _Hyperlink; set => UpdateField(ref _Hyperlink, value, nameof(Hyperlink)); }
 private ColorSchemeIndex? _Hyperlink;

 /// <summary>
 /// Specifies the followed hyperlink.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.FollowedHyperlink))]
 public ColorSchemeIndex? FollowedHyperlink { get => _FollowedHyperlink; set => UpdateField(ref _FollowedHyperlink, value, nameof(FollowedHyperlink)); }
 private ColorSchemeIndex? _FollowedHyperlink;

 /// <summary>
 /// Specifies the extension list.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ColorMappingType.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}