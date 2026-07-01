namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents underline formatting for a text run in WordprocessingML documents.
/// This class provides properties for underline style, color, theme color, and theme color tint/shade, enabling advanced underline customization for character-level formatting.
/// </summary>
[OpenXmlType(typeof(DXW.Underline))]
[DataContract]
[XmlRoot("Underline", Namespace = "DocumentModel.Wordprocessing")]
public partial class Underline : ModelElement<DXW.Underline>
{
 /// <summary>
 /// Underline style, specifying the type of underline applied to the text (e.g., single, double, dotted).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Underline.Val))]
 public UnderlineType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
 private UnderlineType? _Type;

 /// <summary>
 /// Underline color, specified as a hex RGB value or named color.
 /// </summary>
  //[OpenXmlProperties(nameof(DXW.Underline.Color), nameof(DXW.Underline.ThemeColor), 
 //  nameof(DXW.Underline.ThemeTint), nameof(DXW.Underline.ThemeShade))]
 [OpenXmlLoadData(nameof(LoadColor))]
 [OpenXmlUpdateData(nameof(UpdateColor))]
 public DMW.Color? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
 private DMW.Color? _Color;

 /// <summary>
 /// Loads the underline color from the specified OpenXML underline element, applying any associated theme color, tint,
 /// or shade settings.
 /// </summary>
 /// <remarks>This method converts the color information from the OpenXML underline element into the internal
 /// color representation, ensuring that theme-related adjustments are applied as defined in the source
 /// document.</remarks>
 /// <param name = "underline">The OpenXML underline element containing color, theme color, tint, and shade information to be loaded.</param>
 public void LoadColor(DXW.Underline underline)
 {
  this.Color = DMW.Color.FromOpenXml(underline.Color, underline.ThemeColor, underline.ThemeTint, underline.ThemeShade);
 }

 /// <summary>
 /// Updates the color-related properties of the specified underline object to match the current color settings.
 /// </summary>
 /// <remarks>If the current instance does not have a color set, this method clears all color-related
 /// properties on the provided underline object. Otherwise, it applies the current color settings to the
 /// underline.</remarks>
 /// <param name = "underline">The underline object whose color properties will be updated. If the current color is not set, all color properties
 /// of the underline will be cleared.</param>
 public void UpdateColor(DXW.Underline underline)
 {
  if (this.Color is not null)
  {
   (underline.Color, underline.ThemeColor, underline.ThemeTint, underline.ThemeShade) = this.Color.ToOpenXml();
  }
  else
  {
   underline.Color = null;
   underline.ThemeColor = null;
   underline.ThemeTint = null;
   underline.ThemeShade = null;
  }
 }
}