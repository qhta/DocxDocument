namespace DocumentModel.Drawings;
/// <summary>
/// Represents a color that references a system-defined color from the operating system's color scheme
/// with optional transformations. System colors enable documents to adapt to the user's operating system
/// theme and accessibility settings, providing better integration with the desktop environment.
/// </summary>
[OpenXmlType(typeof(DXD.SystemColor))]
[XmlRoot("SystemColor", Namespace = "DocumentModel.Drawings")]
public partial class SystemColor : DrawingsColorBase<DXD.SystemColor>, ISchemeBaseColor, IDrawingColor
{

  /// <summary>
  /// Gets or sets the system color identifier that references a specific OS-defined color.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.SystemColor.Val))]
  public SystemColors? Index { get => _index; set => UpdateField(ref _index, value, nameof(Index)); }
  private SystemColors? _index;

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
  /// When rendering a document, applications should prefer the live system color (via <see cref = "Index"/>)
  /// but fall back to <see cref = "LastColor"/> if the system color cannot be resolved.
  /// This ensures the best possible appearance in all environments while maintaining a reasonable
  /// fallback for non-Windows or incompatible systems.
  /// </para>
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.SystemColor.LastColor))]
  public HexColor? LastColor { get => _LastColor; set => UpdateField(ref _LastColor, value, nameof(LastColor)); }
  private HexColor? _LastColor;

}