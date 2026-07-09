namespace DocumentModel.Drawings;
using Math = System.Math;

/// <summary>
/// Represents a shade color transformation for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.Shade))]
public class Shade: PercentageTransformation<DXD.Shade>
{
  /// <summary>
  /// Transforms the given color by applying the shade transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    l = l * Value;
    l = Math.Clamp(l, 0, 1);
    return new HslColor { Hue = h, Saturation = s, Luminance = l, Alpha = a };
  }
}