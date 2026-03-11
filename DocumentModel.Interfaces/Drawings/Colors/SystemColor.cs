namespace DocumentModel.Drawings;

/// <summary>
/// Represents a color that references a system-defined color from the operating system's color scheme
/// with optional transformations. System colors enable documents to adapt to the user's operating system
/// theme and accessibility settings, providing better integration with the desktop environment.
/// </summary>
/// <remarks>
/// <para>
/// The System Color model allows Office documents to reference colors defined by the operating system,
/// such as window background colors, button face colors, menu text colors, and other UI elements.
/// This provides several benefits:
/// <list type="bullet">
/// <item><description><b>OS integration:</b> Documents adapt to the user's Windows theme (Light, Dark, High Contrast)</description></item>
/// <item><description><b>Accessibility:</b> Automatically respects user accessibility settings and color preferences</description></item>
/// <item><description><b>Consistency:</b> Matches the look and feel of other applications on the system</description></item>
/// <item><description><b>Dynamic updates:</b> Changes when the user switches system themes or color schemes</description></item>
/// </list>
/// </para>
/// <para>
/// System colors are particularly important for:
/// <list type="bullet">
/// <item><description>High contrast mode support for visually impaired users</description></item>
/// <item><description>Dark mode integration on Windows 10/11</description></item>
/// <item><description>Custom Windows themes that override default colors</description></item>
/// <item><description>Terminal Services/Remote Desktop environments with user-specific themes</description></item>
/// </list>
/// </para>
/// <para>
/// The <see cref="LastColor"/> property stores the most recently resolved RGB value for the system color.
/// This serves as a fallback when the document is viewed on systems where the system color cannot be
/// resolved (e.g., non-Windows platforms, or when specific system colors are unavailable). Applications
/// can use this cached value to provide consistent appearance across different environments.
/// </para>
/// <para>
/// In addition to the base system color reference, this model supports the full range of color transformations
/// (tint, shade, alpha, HSL adjustments, RGB modulation, etc.) allowing fine-tuned variations of
/// system colors while maintaining the connection to OS-level settings.
/// </para>
/// <para>
/// System colors are defined by Windows API constants (e.g., COLOR_WINDOW, COLOR_MENUTEXT, COLOR_HIGHLIGHT)
/// and their values can vary significantly depending on the user's Windows theme, high contrast settings,
/// and personalization preferences.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Use the system window background color
/// var windowBackground = new SystemColor 
/// { 
///     Val = SystemColorKind.Window,
///     LastColor = new RGB(0xFFFFFF)  // Fallback: white
/// };
/// 
/// // Use the system highlight color with transparency
/// var transparentHighlight = new SystemColor
/// {
///     Val = SystemColorKind.Highlight,
///     Alpha = 50000,                // 50% transparent
///     LastColor = new RGB(0x0078D4)  // Fallback: blue
/// };
/// 
/// // Create a lighter version of the system button face color
/// var lightButtonFace = new SystemColor
/// {
///     Val = SystemColorKind.ButtonFace,
///     Tint = new Percent(40),       // 40% lighter
///     LastColor = new RGB(0xF0F0F0)  // Fallback: light gray
/// };
/// </code>
/// </example>
public interface SystemColor: ColorType, Color2Type, DrawingColorModifications
{
  /// <summary>
  /// Gets or sets the system color identifier that references a specific OS-defined color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// This property specifies which color from the operating system's color scheme should be used.
  /// The actual RGB value is determined at runtime by querying the OS and will vary based on:
  /// <list type="bullet">
  /// <item><description>The active Windows theme (Light, Dark, or custom themes)</description></item>
  /// <item><description>High contrast mode settings (if enabled for accessibility)</description></item>
  /// <item><description>User personalization settings in Windows Settings</description></item>
  /// <item><description>Desktop Window Manager (DWM) color preferences</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common system color values and their typical uses:
  /// <list type="bullet">
  /// <item><description><b>Window:</b> Background color for content areas and document windows</description></item>
  /// <item><description><b>WindowText:</b> Text color that contrasts with Window background</description></item>
  /// <item><description><b>Highlight:</b> Background color for selected items</description></item>
  /// <item><description><b>HighlightText:</b> Text color for selected items (over Highlight background)</description></item>
  /// <item><description><b>ButtonFace:</b> Background color for buttons and controls</description></item>
  /// <item><description><b>ButtonText:</b> Text color for buttons and controls</description></item>
  /// <item><description><b>MenuText:</b> Text color in menus</description></item>
  /// <item><description><b>GrayText:</b> Color for disabled or inactive text</description></item>
  /// <item><description><b>ActiveCaption:</b> Title bar color for active windows</description></item>
  /// <item><description><b>InactiveCaption:</b> Title bar color for inactive windows</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// These system colors correspond to Windows GetSysColor() API values and ensure that
  /// document elements can integrate seamlessly with the user's desktop environment.
  /// </para>
  /// </remarks>
  public SystemColorKind? Val { get; set; }
  
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
  /// When rendering a document, applications should prefer the live system color (via <see cref="Val"/>)
  /// but fall back to <see cref="LastColor"/> if the system color cannot be resolved.
  /// This ensures the best possible appearance in all environments while maintaining a reasonable
  /// fallback for non-Windows or incompatible systems.
  /// </para>
  /// </remarks>
  public HexRgb? LastColor { get; set; }
  }