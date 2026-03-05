using EnumConverter = DocumentModel.OpenXml.EnumConverter;
using StringConverter = DocumentModel.OpenXml.StringConverter;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a border definition for elements in a WordprocessingML document.
/// This class provides properties for border style, color, width, spacing, shadow, and frame effect, enabling advanced formatting and visual separation of document content.
/// </summary>
[OpenXmlType(typeof(DXW.BorderType))]
public partial class Border: ModelElement<DXW.BorderType>
{
  /// <summary>
  /// Border style, specifying the type of border (e.g., single, double, dashed).
  /// </summary>
  [OpenXmlLoadData(nameof(LoadBorderType))]
  [OpenXmlUpdateData(nameof(UpdateBorderType))]
  public BorderType? Type { get => _type; set => UpdateField(ref _type, value, nameof(Type)); }

  private BorderType? _type;

  /// <summary>
  /// Border art style, specifying the type of decorative border (e.g., Apples, Clocks, ZigZag).
  /// </summary>
  [OpenXmlLoadData(nameof(LoadBorderType))]
  [OpenXmlUpdateData(nameof(UpdateBorderType))]
  public string? ArtStyle { get => _ArtStyle; set => UpdateField(ref _ArtStyle, value, nameof(ArtStyle)); }

  private string? _ArtStyle;

  /// <summary>
  /// Border color, specified as an abstract color value.
  /// </summary>
  [OpenXmlLoadData(nameof(LoadColor))]
  [OpenXmlUpdateData(nameof(UpdateColor))]
  public DMW.Color? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }

  private DMW.Color? _Color;

  /// <summary>
  /// Border width, specified in twips.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.BorderType.Size))]
  public Twips? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

  private Twips? _Width;

  /// <summary>
  /// Border spacing measurement, specifying the space between the border and the content.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.BorderType.Space))]
  public Twips? Space { get => _Space; set => UpdateField(ref _Space, value, nameof(Space)); }

  private Twips? _Space;

  /// <summary>
  /// Indicates whether the border has a shadow effect.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.BorderType.Shadow))]
  public bool? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }

  private bool? _Shadow;

  /// <summary>
  /// Indicates whether the border has a frame effect.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.BorderType.Frame))]
  public bool? Frame { get => _Frame; set => UpdateField(ref _Frame, value, nameof(Frame)); }

  private bool? _Frame;

  /// <summary>
  /// Loads the border style from the specified border object, setting the Style or ArtStyle properties based on the
  /// border's value.
  /// </summary>
  /// <remarks>If the border's value is valid, the method attempts to convert it to a BorderStyle. If the
  /// conversion fails, it falls back to converting the border to an ArtStyle string.</remarks>
  /// <param name="border">The border object from which to load the style. This parameter must not be null and should contain a valid border
  /// value.</param>
  public void LoadBorderType(DXW.BorderType border)
  {
    if (border.Val != null)
    {
      var s = (string)EnumConverter.ConvertFromOpenXmlEnumValueToString(border.Val)!;
      if (Enum.TryParse(s, true, out BorderType style))
        Type = style;
      else
        ArtStyle = s;
    }
  }

  /// <summary>
  /// Updates the style of the specified border based on the current style or art style settings.
  /// </summary>
  /// <remarks>If the Style property is set, the border's value is updated using the converted Style. If Style
  /// is not set but ArtStyle is, the border's value is updated using the converted ArtStyle. If neither property is
  /// set, the border's value is cleared.</remarks>
  /// <param name="border">The border to update with the new style value. This parameter cannot be null.</param>
  public void UpdateBorderType(DXW.BorderType border)
  {
    if (Type != null)
      border.Val =
        (DX.EnumValue<DXW.BorderValues>)EnumConverter.ConvertTo(Type, typeof(DX.EnumValue<DXW.BorderValues>))!;
    else if (ArtStyle != null)
      border.Val =
        (DX.EnumValue<DXW.BorderValues>)EnumConverter.ConvertTo(ArtStyle, typeof(DX.EnumValue<DXW.BorderValues>))!;
    else
      border.Val = null;
  }


  /// <summary>
  /// Loads the border color from the specified OpenXML border element, applying any associated theme color, tint,
  /// or shade settings.
  /// </summary>
  /// <remarks>This method converts the color information from the OpenXML border element into the internal
  /// color representation, ensuring that theme-related adjustments are applied as defined in the source
  /// document.</remarks>
  /// <param name="border">The OpenXML border element containing color, theme color, tint, and shade information to be loaded.</param>
  public void LoadColor(DXW.BorderType border)
  {
    this.Color = DMW.Color.FromOpenXml(border.Color, border.ThemeColor, border.ThemeTint, border.ThemeShade);
  }

  /// <summary>
  /// Updates the color-related properties of the specified border object to match the current color settings.
  /// </summary>
  /// <remarks>If the current instance does not have a color set, this method clears all color-related
  /// properties on the provided border object. Otherwise, it applies the current color settings to the
  /// border.</remarks>
  /// <param name="border">The border object whose color properties will be updated. If the current color is not set, all color properties
  /// of the border will be cleared.</param>
  public void UpdateColor(DXW.BorderType border)
  {
    if (this.Color is not null)
    {
      (border.Color, border.ThemeColor, border.ThemeTint, border.ThemeShade) = this.Color.ToOpenXml();
    }
    else
    {
      border.Color = null;
      border.ThemeColor = null;
      border.ThemeTint = null;
      border.ThemeShade = null;
    }
  }
}