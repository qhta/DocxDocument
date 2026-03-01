using EnumConverter = DocumentModel.OpenXml.EnumConverter;
using StringConverter = DocumentModel.OpenXml.StringConverter;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a border definition for elements in a WordprocessingML document.
/// This class provides properties for border style, color, width, spacing, shadow, and frame effect, enabling advanced formatting and visual separation of document content.
/// </summary>
[OpenXmlType(typeof(DXW.Border))]
public partial class Border : ModelElement<DXW.Border>
{
  /// <summary>
  /// Border style, specifying the type of border (e.g., single, double, dashed).
  /// </summary>
  [OpenXmlLoadData(nameof(LoadBorderStyle))]
  [OpenXmlUpdateData(nameof(UpdateBorderStyle))]
  public BorderStyle? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

  private BorderStyle? _Style;

  /// <summary>
  /// Border art style, specifying the type of decorative border (e.g., Apples, Clocks, ZigZag).
  /// </summary>
  [OpenXmlLoadData(nameof(LoadBorderStyle))]
  [OpenXmlUpdateData(nameof(UpdateBorderStyle))]
  public string? ArtStyle { get => _ArtStyle; set => UpdateField(ref _ArtStyle, value, nameof(ArtStyle)); }

  private string? _ArtStyle;

  /// <summary>
  /// Border color, specified as an abstract color value.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Border.Color))]
  public string? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }

  private string? _Color;
  /// <summary>
  /// Border width, specified in twips.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Border.Size))]
  public Twips? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

  private Twips? _Width;
  /// <summary>
  /// Border spacing measurement, specifying the space between the border and the content.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Border.Space))]
  public Twips? Space { get => _Space; set => UpdateField(ref _Space, value, nameof(Space)); }

  private Twips? _Space;
  /// <summary>
  /// Indicates whether the border has a shadow effect.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Border.Shadow))]
  public bool? Shadow { get => _Shadow; set => UpdateField(ref _Shadow, value, nameof(Shadow)); }

  private bool? _Shadow;
  /// <summary>
  /// Indicates whether the border has a frame effect.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Border.Frame))]
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
  public void LoadBorderStyle(DXW.Border border)
  {
    if (border.Val != null)
    {
      var s = (string)EnumConverter.ConvertFromOpenXmlEnumValueToString(border.Val)!;

      if (Enum.TryParse(s, true, out BorderStyle style))
        Style = style;
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
  public void UpdateBorderStyle(DXW.Border border)
  {
    if (Style != null)
      border.Val = (DX.EnumValue<DXW.BorderValues>)EnumConverter.ConvertTo(Style, typeof(DX.EnumValue<DXW.BorderValues>))!;
    else if (ArtStyle != null)
      border.Val = (DX.EnumValue<DXW.BorderValues>)EnumConverter.ConvertTo(ArtStyle, typeof(DX.EnumValue<DXW.BorderValues>))!;
    else
      border.Val = null;
  }
}