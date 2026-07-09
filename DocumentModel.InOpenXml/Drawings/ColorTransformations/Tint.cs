namespace DocumentModel.Drawings;
using Math = System.Math;

/// <summary>
/// Represents a tint color transformation for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.Tint))]
public class Tint: PercentageTransformation<DXD.Tint>
{
  /// <summary>
  /// Transforms the given color by applying the tint transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    var tint = Value / 100.0;
    l = l*tint + (1 - tint);
    l = Math.Clamp(l, 0, 1);
    return new HslColor { Hue = h, Saturation = s, Luminance = l, Alpha = a };
  }
}