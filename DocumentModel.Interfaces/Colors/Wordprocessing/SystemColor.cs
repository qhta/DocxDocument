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
public interface SystemColor: IModelElement
{
  /// <summary>
  /// Gets or sets the system color identifier that references a specific OS-defined color.
  /// </summary>
  /// <value>
  /// A <see cref="SystemColorKind"/> value specifying which operating system color to reference
  /// (e.g., Window, WindowText, Highlight, ButtonFace, MenuText).
  /// If <see langword="null"/>, no system color is referenced.
  /// </value>
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
  /// <value>
  /// An <see cref="IRGB"/> value containing the most recently resolved RGB color value
  /// for this system color. If <see langword="null"/>, no fallback color is stored.
  /// </value>
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
  public IRGB? LastColor { get; set; }
  
  /// <summary>
  /// Gets or sets the tint value to lighten the system color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A tint lightens the system color by mixing it with white. 
  /// The <see cref="IPercent"/> value typically ranges from 0% to 100%, where:
  /// <list type="bullet">
  /// <item><description>0% or null = no tint (original system color)</description></item>
  /// <item><description>50% = system color mixed 50/50 with white</description></item>
  /// <item><description>100% = fully white</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Tinting system colors is useful for creating subtle backgrounds or highlights that
  /// adapt to the user's theme. For example, a 90% tint of the Window color creates a
  /// very subtle background that remains readable in both light and dark themes.
  /// </para>
  /// <para>
  /// If the value is <see langword="null"/>, no tint is applied. 
  /// Tint and shade are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  public IPercent? Tint { get; set; }
  
  /// <summary>
  /// Gets or sets the shade value to darken the system color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A shade darkens the system color by mixing it with black.
  /// The <see cref="IPercent"/> value typically ranges from 0% to 100%, where:
  /// <list type="bullet">
  /// <item><description>0% or null = no shade (original system color)</description></item>
  /// <item><description>50% = system color mixed 50/50 with black</description></item>
  /// <item><description>100% = fully black</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Shading system colors is useful for creating borders, separators, or emphasis elements
  /// that adapt to the user's theme. For example, a 25% shade of the ButtonFace color
  /// creates a subtle border that works in both light and dark themes.
  /// </para>
  /// <para>
  /// Shade and tint are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  public IPercent? Shade { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether the complement (opposite) color operation is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, the system color is transformed to its complement on the color wheel
  /// (e.g., if the system color is blue, it becomes yellow/orange). Default is <see langword="false"/>.
  /// This transformation is applied after the base system color is resolved from the OS.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean Complement { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether the color inversion operation is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, each RGB component of the system color is inverted (255 - value),
  /// creating a negative effect. Default is <see langword="false"/>.
  /// This can be useful for creating contrast effects that adapt to the system theme.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean Inverse { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether the system color is converted to grayscale.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, the system color is desaturated to create a grayscale value
  /// based on the perceived luminance of the original color. Default is <see langword="false"/>.
  /// This maintains the brightness characteristics of the system color while removing color information,
  /// which can be useful for creating monochrome designs that still respect system theme brightness.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean Gray { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute alpha (transparency) value.
  /// </summary>
  /// <remarks>
  /// Specifies the opacity of the system color where 0 is fully transparent and 100000 is fully opaque (100%).
  /// Values in between create semi-transparent colors. If <see langword="null"/>, full opacity (100000) is assumed.
  /// Transparency is particularly useful with system colors to create subtle overlays that adapt to the user's theme.
  /// </remarks>
  public Int32? Alpha { get; set; }
  
  /// <summary>
  /// Gets or sets the alpha (transparency) offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the base alpha value. Range is typically -100000 to +100000.
  /// Positive values increase opacity, negative values increase transparency.
  /// </remarks>
  public Int32? AlphaOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the alpha (transparency) modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base alpha by this percentage. A value of 50000 (50%) makes the color twice as transparent.
  /// Range is 0 to 100000, where 100000 means no change.
  /// </remarks>
  public Int32? AlphaModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute hue value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the hue angle in degrees (0-360), represented as 0-21600000 units (1/60000th of a degree).
  /// Overrides the hue component of the system color while maintaining saturation and luminance.
  /// Hue represents the color's position on the color wheel: 0=red, 60=yellow, 120=green, 180=cyan, 240=blue, 300=magenta.
  /// </remarks>
  public Int32? Hue { get; set; }
  
  /// <summary>
  /// Gets or sets the hue offset adjustment in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the system color's hue value to shift the color around the color wheel.
  /// Values wrap around (adding 360 degrees returns to the same hue).
  /// This can be used to create coordinated color variations of system colors.
  /// </remarks>
  public Int32? HueOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the hue modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the system color's hue by this percentage. Used for relative hue adjustments.
  /// Range is 0 to 100000, where 100000 means no change.
  /// </remarks>
  public Int32? HueModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute saturation value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the color saturation where 0 is grayscale and 100000 is fully saturated (100%).
  /// Overrides the saturation component of the system color.
  /// Saturation determines the intensity or vividness of the color.
  /// </remarks>
  public Int32? Saturation { get; set; }
  
  /// <summary>
  /// Gets or sets the saturation offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the system color's saturation value. Range is typically -100000 to +100000.
  /// Positive values make colors more vivid, negative values make them more gray.
  /// </remarks>
  public Int32? SaturationOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the saturation modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the system color's saturation by this percentage. A value of 50000 (50%) reduces saturation by half.
  /// Range is 0 to 100000, where 100000 means no change. Commonly used to create muted variations
  /// of system colors that still adapt to the user's theme.
  /// </remarks>
  public Int32? SaturationModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute luminance value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the brightness where 0 is black, 50000 is the color at normal brightness (50%), 
  /// and 100000 is white. Overrides the luminance component of the system color.
  /// Luminance determines how light or dark the color appears.
  /// </remarks>
  public Int32? Luminance { get; set; }
  
  /// <summary>
  /// Gets or sets the luminance offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the system color's luminance value. Range is typically -100000 to +100000.
  /// Positive values make colors lighter, negative values make them darker.
  /// This provides an alternative to tint/shade with more precise control in HSL space.
  /// </remarks>
  public Int32? LuminanceOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the luminance modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the system color's luminance by this percentage. A value of 50000 (50%) reduces brightness by half.
  /// Range is 0 to 100000, where 100000 means no change. Commonly used to create lighter or darker
  /// variations of system colors that maintain accessibility across different OS themes.
  /// </remarks>
  public Int32? LuminanceModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute red channel value override.
  /// </summary>
  /// <remarks>
  /// Overrides the red component (0-100000 representing 0-255) of the system color's RGB value.
  /// Use this to set an explicit red value independent of the OS-provided system color.
  /// When set, this value takes precedence over the red component from the system color.
  /// </remarks>
  public Int32? Red { get; set; }
  
  /// <summary>
  /// Gets or sets the red channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the red channel value of the system color. Range is typically -100000 to +100000.
  /// Applied after the base red value is resolved from the system color.
  /// </remarks>
  public Int32? RedOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the red channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the red channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the red component by half.
  /// </remarks>
  public Int32? RedModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute green channel value override.
  /// </summary>
  /// <remarks>
  /// Overrides the green component (0-100000 representing 0-255) of the system color's RGB value.
  /// Use this to set an explicit green value independent of the OS-provided system color.
  /// When set, this value takes precedence over the green component from the system color.
  /// </remarks>
  public Int32? Green { get; set; }
  
  /// <summary>
  /// Gets or sets the green channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the green channel value of the system color. Range is typically -100000 to +100000.
  /// Applied after the base green value is resolved from the system color.
  /// </remarks>
  public Int32? GreenOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the green channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the green channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the green component by half.
  /// </remarks>
  public Int32? GreenModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute blue channel value override.
  /// </summary>
  /// <remarks>
  /// Overrides the blue component (0-100000 representing 0-255) of the system color's RGB value.
  /// Use this to set an explicit blue value independent of the OS-provided system color.
  /// When set, this value takes precedence over the blue component from the system color.
  /// </remarks>
  public Int32? Blue { get; set; }
  
  /// <summary>
  /// Gets or sets the blue channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the blue channel value of the system color. Range is typically -100000 to +100000.
  /// Applied after the base blue value is resolved from the system color.
  /// </remarks>
  public Int32? BlueOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the blue channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the blue channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the blue component by half.
  /// </remarks>
  public Int32? BlueModulation { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether gamma correction is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, applies standard gamma correction (typically gamma 2.2)
  /// to the system color to convert from linear RGB space to display-corrected RGB. 
  /// Default is <see langword="false"/>.
  /// Gamma correction adjusts colors to appear correct on display devices.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean Gamma { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether inverse gamma correction is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, applies inverse gamma correction to the system color
  /// to convert from display-corrected RGB to linear RGB space. Default is <see langword="false"/>.
  /// This is the opposite of standard gamma correction.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean InverseGamma { get; set; }
}