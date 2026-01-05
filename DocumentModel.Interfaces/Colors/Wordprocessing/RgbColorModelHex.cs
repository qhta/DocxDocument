namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an RGB color using hexadecimal notation with optional transformations for WordprocessingML.
/// This is a simplified version of the DrawingML RGB color model, specifically designed for text colors,
/// borders, shading, and other Wordprocessing document formatting where a more limited set of 
/// color transformations is sufficient.
/// </summary>
/// <remarks>
/// <para>
/// The WordprocessingML RGB Color Model uses hexadecimal notation (e.g., "FF0000" for red) with a 
/// subset of the color transformation capabilities available in the full DrawingML color model.
/// This interface is used specifically for Word document formatting elements such as:
/// <list type="bullet">
/// <item><description>Text and paragraph colors (run properties)</description></item>
/// <item><description>Border colors (table borders, paragraph borders)</description></item>
/// <item><description>Shading and background colors</description></item>
/// <item><description>Table cell backgrounds</description></item>
/// <item><description>Highlighting and emphasis effects</description></item>
/// </list>
/// </para>
/// <para>
/// This color model supports key transformations:
/// <list type="bullet">
/// <item><description><b>Tint/Shade:</b> Lighten or darken the base RGB color</description></item>
/// <item><description><b>Alpha:</b> Control transparency (0-100000, where 100000 is fully opaque)</description></item>
/// <item><description><b>Hue Modulation:</b> Adjust the hue component</description></item>
/// <item><description><b>Saturation:</b> Control color intensity with absolute and relative adjustments</description></item>
/// <item><description><b>Luminance:</b> Control brightness with absolute and relative adjustments</description></item>
/// </list>
/// </para>
/// <para>
/// Unlike the full DrawingML <see cref="DocumentModel.Drawings.RgbColorModelHex"/> interface, this 
/// WordprocessingML version:
/// <list type="bullet">
/// <item><description>Does not include individual RGB channel modulation (Red/Green/Blue offsets and modulation)</description></item>
/// <item><description>Does not include color effect operations (Complement, Inverse, Gray, Gamma)</description></item>
/// <item><description>Does not include hue/saturation/luminance offset properties</description></item>
/// <item><description>Focuses on the most commonly used transformations for document text and simple graphics</description></item>
/// </list>
/// This simplified model provides sufficient functionality for typical Word document formatting
/// while maintaining better compatibility with older Office versions.
/// </para>
/// <para>
/// Transformation values use the range 0-100000 to represent 0% to 100%, providing fine-grained
/// control with 1/1000th of a percent precision.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create a simple red color for text
/// var red = new RgbColorModelHex 
/// { 
///     RGB = new RGB(0xFF0000)
/// };
/// 
/// // Create a semi-transparent blue for highlighting
/// var transparentBlue = new RgbColorModelHex
/// {
///     RGB = new RGB(0x0000FF),
///     Alpha = 50000  // 50% opacity
/// };
/// 
/// // Create a lighter shade for table cell background
/// var lightGray = new RgbColorModelHex
/// {
///     RGB = new RGB(0x808080),
///     Tint = 60000,  // 60% lighter
///     LuminanceModulation = 120000  // Increase brightness to 120%
/// };
/// </code>
/// </example>
public interface RgbColorModelHex:
{
  /// <summary>
  /// Gets or sets the base RGB color value in hexadecimal format.
  /// </summary>
  /// <remarks>
  /// <para>
  /// This is the primary color value specified as a 24-bit RGB color. The hexadecimal format
  /// provides a compact and familiar way to specify colors, matching standard web/CSS notation.
  /// </para>
  /// <para>
  /// Documents using RGB colors
  /// with transformations require compatibility with Office 2010 or higher to display correctly.
  /// In earlier versions, only the base RGB value may be displayed without transformations.
  /// </para>
  /// </remarks>
  public RGB? RGB { get; set; }
  
  /// <summary>
  /// Gets or sets the tint value to lighten the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A tint lightens the base RGB color by mixing it with white. Values range from 0 to 100000:
  /// <list type="bullet">
  /// <item><description>0 or null = no tint (original RGB color)</description></item>
  /// <item><description>50000 = 50% tint (color mixed 50/50 with white)</description></item>
  /// <item><description>100000 = 100% tint (fully white)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Tint is commonly used in Word documents for:
  /// <list type="bullet">
  /// <item><description>Light background shading in tables (e.g., 95% tint for subtle alternating rows)</description></item>
  /// <item><description>Muted text colors for secondary content</description></item>
  /// <item><description>Soft borders that don't dominate the content</description></item>
  /// <item><description>Highlight colors that remain readable</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Tint and shade are mutually exclusive transformations; typically only one should be applied.
  /// </para>
  /// </remarks>
  public Int32? Tint { get; set; }
  
  /// <summary>
  /// Gets or sets the shade value to darken the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A shade darkens the base RGB color by mixing it with black. Values range from 0 to 100000:
  /// <list type="bullet">
  /// <item><description>0 or null = no shade (original RGB color)</description></item>
  /// <item><description>50000 = 50% shade (color mixed 50/50 with black)</description></item>
  /// <item><description>100000 = 100% shade (fully black)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Shade is commonly used in Word documents for:
  /// <list type="bullet">
  /// <item><description>Darker text colors for emphasis or headers</description></item>
  /// <item><description>Border colors that provide strong visual separation</description></item>
  /// <item><description>Table header backgrounds with darker colors</description></item>
  /// <item><description>Drop shadow effects</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Shade and tint are mutually exclusive transformations; typically only one should be applied.
  /// </para>
  /// </remarks>
  public Int32? Shade { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute alpha (transparency) value.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Specifies the opacity of the color:
  /// <list type="bullet">
  /// <item><description>0 = fully transparent (invisible)</description></item>
  /// <item><description>50000 = 50% transparent (semi-transparent)</description></item>
  /// <item><description>100000 or null = fully opaque (default)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Alpha transparency in WordprocessingML is useful for:
  /// <list type="bullet">
  /// <item><description>Text highlighting that doesn't completely obscure underlying content</description></item>
  /// <item><description>Watermarks and background text</description></item>
  /// <item><description>Overlay effects in text boxes and shapes</description></item>
  /// <item><description>Subtle shading that allows grid lines or text to show through</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Note that transparency support may vary depending on the rendering context (screen, print, PDF export).
  /// Not all document viewers support alpha transparency for all formatting elements.
  /// </para>
  /// </remarks>
  public Int32? Alpha { get; set; }
  
  /// <summary>
  /// Gets or sets the hue modulation percentage.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Multiplies the RGB color's hue by this percentage in HSL color space. Range is 0 to 100000:
  /// <list type="bullet">
  /// <item><description>100000 or null = no change to hue</description></item>
  /// <item><description>50000 = hue compressed to 50% of original value</description></item>
  /// <item><description>Values &lt; 100000 = compress the hue value</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Hue modulation provides subtle color adjustments for creating coordinated color variations
  /// in Word documents. This is less commonly used than tint/shade but can create sophisticated
  /// color harmonies for professional document templates.
  /// </para>
  /// </remarks>
  public Int32? HueModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute saturation value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Overrides the saturation component of the RGB color:
  /// <list type="bullet">
  /// <item><description>0 = completely desaturated (grayscale)</description></item>
  /// <item><description>50000 = 50% saturated (muted color)</description></item>
  /// <item><description>100000 or null = fully saturated (vivid color, or RGB's original saturation)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Setting an absolute saturation value is useful for creating consistent muted or vibrant
  /// color schemes across a document. For example, reducing saturation to 30000-50000 creates
  /// professional, subtle colors suitable for business documents.
  /// </para>
  /// </remarks>
  public Int32? Saturation { get; set; }
  
  /// <summary>
  /// Gets or sets the saturation offset adjustment.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Adds or subtracts from the RGB color's saturation in HSL space:
  /// <list type="bullet">
  /// <item><description>Positive values = increase saturation (more vivid)</description></item>
  /// <item><description>Negative values = decrease saturation (more muted/gray)</description></item>
  /// <item><description>0 or null = no change</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Saturation offset allows relative adjustments that work well across different base colors,
  /// creating consistent color mood adjustments throughout a document.
  /// </para>
  /// </remarks>
  public Int32? SaturationOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the saturation modulation percentage.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Multiplies the RGB color's saturation by this percentage:
  /// <list type="bullet">
  /// <item><description>100000 or null = no change</description></item>
  /// <item><description>50000 = saturation reduced to 50% (more muted)</description></item>
  /// <item><description>150000 = saturation increased to 150% (more vivid)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Saturation modulation is commonly used in Word documents to create:
  /// <list type="bullet">
  /// <item><description>Pastel colors for backgrounds (40000-60000 modulation)</description></item>
  /// <item><description>Muted text colors for body text (60000-80000 modulation)</description></item>
  /// <item><description>Soft alternating row colors in tables</description></item>
  /// <item><description>Professional color schemes with reduced color intensity</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public Int32? SaturationModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute luminance (brightness) value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Overrides the luminance component of the RGB color:
  /// <list type="bullet">
  /// <item><description>0 = black (no brightness)</description></item>
  /// <item><description>50000 = normal brightness for the RGB color</description></item>
  /// <item><description>100000 or null = white (maximum brightness, or RGB's original luminance)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Setting an absolute luminance value ensures consistent brightness across different colors,
  /// which is important for maintaining readability and accessibility in Word documents.
  /// </para>
  /// </remarks>
  public Int32? Luminance { get; set; }
  
  /// <summary>
  /// Gets or sets the luminance (brightness) offset adjustment.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Adds or subtracts from the RGB color's luminance in HSL space:
  /// <list type="bullet">
  /// <item><description>Positive values = lighter (toward white)</description></item>
  /// <item><description>Negative values = darker (toward black)</description></item>
  /// <item><description>0 or null = no change</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Luminance offset provides an alternative to tint/shade with more precise control in HSL color space.
  /// It can create lighter or darker variations while potentially preserving more of the original 
  /// color's saturation compared to tint/shade operations.
  /// </para>
  /// </remarks>
  public Int32? LuminanceOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the luminance (brightness) modulation percentage.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Multiplies the RGB color's luminance by this percentage:
  /// <list type="bullet">
  /// <item><description>100000 or null = no change</description></item>
  /// <item><description>50000 = luminance reduced to 50% (darker)</description></item>
  /// <item><description>150000 = luminance increased to 150% (lighter)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Luminance modulation is one of the most commonly used transformations for RGB colors in Word.
  /// Common patterns in Word document formatting include:
  /// <list type="bullet">
  /// <item><description><b>40000-60000 (40-60%):</b> Dark variations for text, headers, or borders</description></item>
  /// <item><description><b>80000 (80%):</b> Slightly darker for subtle emphasis</description></item>
  /// <item><description><b>90000-95000 (90-95%):</b> Very light for table row shading</description></item>
  /// <item><description><b>110000-120000 (110-120%):</b> Slightly lighter for highlights</description></item>
  /// </list>
  /// These modulation values create professional-looking documents with good contrast and readability.
  /// </para>
  /// </remarks>
  public Int32? LuminanceModulation { get; set; }
}