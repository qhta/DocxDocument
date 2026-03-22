using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the glow effect applied to a drawing element in a Wordprocessing document.
/// This class provides properties for configuring the glow radius and color, enabling visual emphasis and styling for graphical objects.
/// </summary>
[OpenXmlType(typeof(DXO10W.Glow))]
public partial class Glow : ModelElement<DXO10W.Glow>, IDrawingProperty
{
  /// <summary>
  /// The radius of the glow effect, specified in EMUs (English Metric Units), determining the size of the glow around the element.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10W.Glow.GlowRadius))]
  public Int64? GlowRadius { get => _GlowRadius; set => UpdateField(ref _GlowRadius, value, nameof(GlowRadius)); }
  private Int64? _GlowRadius;
  /// <summary>
  /// The RGB color value for the glow effect, allowing precise color specification using hexadecimal notation.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10W.Glow.RgbColorModelHex))]
  public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }
  private RgbColorModelHex? _RgbColorModelHex;
  /// <summary>
  /// The scheme color for the glow effect, enabling the use of document-defined color schemes for consistent styling.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10W.Glow.SchemeColor))]
  public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }
  private SchemeColor? _SchemeColor;
}