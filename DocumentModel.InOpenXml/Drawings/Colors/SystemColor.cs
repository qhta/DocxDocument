namespace DocumentModel.Drawings;
/// <summary>
/// Represents a color that references a system-defined color from the operating system's color scheme
/// with optional transformations. System colors enable documents to adapt to the user's operating system
/// theme and accessibility settings, providing better integration with the desktop environment.
/// </summary>
[OpenXmlType(typeof(DXD.SystemColor))]
[XmlRoot("SystemColor", Namespace = "DocumentModel.Drawings")]
public partial class SystemColor : AbstractColor<DXD.SystemColor>, ISchemeBaseColor, IDrawingColor
{

  /// <summary>
  /// Gets or sets the system color identifier that references a specific OS-defined color.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.SystemColor.Val))]
  public SystemColors? Val { get => _val; set => UpdateField(ref _val, value, nameof(Val)); }
  private SystemColors? _val;

  /// <summary>
  /// Gets or sets the last known RGB value for this system color, used as a fallback.
  /// </summary>
  /// <remarks>
  /// <para>
  /// This property serves multiple important purposes:
  /// <list type="bullet">
  /// <item><description><b>Cross-platform compatibility:</b> Provides a concrete color value when viewing documents on non-Windows systems</description></item>
  /// <item><description><b>Fallback rendering:</b> Used when the system color cannot be resolved (e.g., in print preview, PDF export)</description></item>
  /// <item><description><b>Document portability:</b> Ensures consistent appearance when the document is moved between systems</description></item>
  /// <item><description><b>Color caching:</b> Stores the resolved color to avoid repeated OS queries</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Applications typically update this property when:
  /// <list type="bullet">
  /// <item><description>The document is first opened and system colors are resolved</description></item>
  /// <item><description>The user changes their Windows theme or high contrast settings</description></item>
  /// <item><description>The document is saved (to preserve the current color values)</description></item>
  /// <item><description>The document is rendered for export (PDF, image, etc.)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// When rendering a document, applications should prefer the live system color (via <see cref = "Val"/>)
  /// but fall back to <see cref = "LastColor"/> if the system color cannot be resolved.
  /// This ensures the best possible appearance in all environments while maintaining a reasonable
  /// fallback for non-Windows or incompatible systems.
  /// </para>
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.SystemColor.LastColor))]
  public HexColor? LastColor { get => _LastColor; set => UpdateField(ref _LastColor, value, nameof(LastColor)); }
  private HexColor? _LastColor;

  /// <summary>
  /// Tint value to lighten the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A tint value lightens the base color by mixing it with white. 
  /// Values range from 0 to 100000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no tint applied (original color)</description></item>
  /// <item><description>50000 = 50% tint (color mixed 50/50 with white)</description></item>
  /// <item><description>100000 = 100% tint (fully white)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If the value is <see langword="null"/>, no tint is applied. 
  /// Tint and shade are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Tint))]
  public Percentage? Tint { get => _Tint; set => UpdateField(ref _Tint, value, nameof(Tint)); }
  private Percentage? _Tint;

  /// <summary>
  /// Shade value to darken the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A shade value darkens the base color by mixing it with black.
  /// Values range from 0 to 100000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no shade applied (original color)</description></item>
  /// <item><description>50000 = 50% shade (color mixed 50/50 with black)</description></item>
  /// <item><description>100000 = 100% shade (fully black)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Shade and tint are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Shade))]
  public Percentage? Shade { get => _Shade; set => UpdateField(ref _Shade, value, nameof(Shade)); }
  private Percentage? _Shade;
}