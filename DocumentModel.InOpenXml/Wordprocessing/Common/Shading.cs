namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents shading formatting for a drawing element in a Wordprocessing document.
/// This class provides properties for specifying the shading pattern, foreground color, and background color, enabling advanced visual effects for graphical objects.
/// </summary>
[OpenXmlType(typeof(DXW.Shading))]
[DataContract]
[XmlRoot("Shading", Namespace = "DocumentModel.Wordprocessing")]
public partial class Shading : ModelElement<DXW.Shading>
{
 /// <summary>
 /// The shading pattern applied to the drawing element, determining the style of the fill pattern.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Shading.Val))]
 [Required]
 public ShadingPattern? Pattern { get => _Pattern; set => UpdateField(ref _Pattern, value, nameof(Pattern)); }
 private ShadingPattern? _Pattern;

 /// <summary>
 /// The color of the pattern foreground, specifying the primary color used in the shading pattern.
 /// </summary>
 [OpenXmlLoadData(nameof(LoadForegroundColor))]
 [OpenXmlUpdateData(nameof(UpdateForegroundColor))]
 public DMW.WordColor? ForegroundColor { get => _ForegroundColor; set => UpdateField(ref _ForegroundColor, value, nameof(ForegroundColor)); }
 private DMW.WordColor? _ForegroundColor;

 /// <summary>
 /// The color of the pattern background, specifying the secondary color used in the shading pattern.
 /// </summary>
 [OpenXmlLoadData(nameof(LoadBackgroundColor))]
 [OpenXmlUpdateData(nameof(UpdateBackgroundColor))]
 public DMW.WordColor? BackgroundColor { get => _BackgroundColor; set => UpdateField(ref _BackgroundColor, value, nameof(BackgroundColor)); }
 private DMW.WordColor? _BackgroundColor;

 /// <summary>
 /// Loads the shading foreground color from the specified OpenXML shading element, applying any associated theme color, tint,
 /// or shade settings.
 /// </summary>
 /// <remarks>This method converts the color information from the OpenXML shading element into the internal
 /// color representation, ensuring that theme-related adjustments are applied as defined in the source
 /// document.</remarks>
 /// <param name = "shading">The OpenXML shading element containing color, theme color, tint, and shade information to be loaded.</param>
 public void LoadForegroundColor(DXW.Shading shading)
 {
  this.ForegroundColor = DMW.WordColor.FromOpenXml(shading.Color, shading.ThemeColor, shading.ThemeTint, shading.ThemeShade);
 }

 /// <summary>
 /// Updates the color-related properties of the specified shading object to match the current foreground color settings.
 /// </summary>
 /// <remarks>If the current instance does not have a foreground color set, this method clears all color-related
 /// properties on the provided shading object. Otherwise, it applies the current foreground color settings to the
 /// shading.</remarks>
 /// <param name = "shading">The shading object whose color properties will be updated. If the current color is not set, all color properties
 /// of the shading will be cleared.</param>
 public void UpdateForegroundColor(DXW.Shading shading)
 {
  if (this.ForegroundColor is not null)
  {
   (shading.Color, shading.ThemeColor, shading.ThemeTint, shading.ThemeShade) = this.ForegroundColor.ToOpenXml();
  }
  else
  {
   shading.Color = null;
   shading.ThemeColor = null;
   shading.ThemeTint = null;
   shading.ThemeShade = null;
  }
 }

 /// <summary>
 /// Loads the shading background color from the specified OpenXML shading element, applying any associated theme color, tint,
 /// or shade settings.
 /// </summary>
 /// <remarks>This method converts the color information from the OpenXML shading element into the internal
 /// color representation, ensuring that theme-related adjustments are applied as defined in the source
 /// document.</remarks>
 /// <param name = "shading">The OpenXML shading element containing color, theme color, tint, and shade information to be loaded.</param>
 public void LoadBackgroundColor(DXW.Shading shading)
 {
  this.BackgroundColor = DMW.WordColor.FromOpenXml(shading.Fill, shading.ThemeFill, shading.ThemeFillTint, shading.ThemeFillShade);
 }

 /// <summary>
 /// Updates the color-related properties of the specified shading object to match the current background color settings.
 /// </summary>
 /// <remarks>If the current instance does not have a background color set, this method clears all color-related
 /// properties on the provided shading object. Otherwise, it applies the current background color settings to the
 /// shading.</remarks>
 /// <param name = "shading">The shading object whose color properties will be updated. If the current color is not set, all color properties
 /// of the shading will be cleared.</param>
 public void UpdateBackgroundColor(DXW.Shading shading)
 {
  if (this.BackgroundColor is not null)
  {
   (shading.Fill, shading.ThemeFill, shading.ThemeFillTint, shading.ThemeFillShade) = this.BackgroundColor.ToOpenXml();
  }
  else
  {
   shading.Fill = null;
   shading.ThemeFill = null;
   shading.ThemeFillTint = null;
   shading.ThemeFillShade = null;
  }
 }
}