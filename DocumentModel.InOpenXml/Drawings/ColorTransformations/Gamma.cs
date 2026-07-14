using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Drawings;

using Math = System.Math;

/// <summary>
/// Represents a gamma color transformation for drawing elements.
/// Applies standard gamma correction (typically gamma 2.2)
/// to convert from linear RGB space to display-corrected RGB.
/// </summary>
[OpenXmlType(typeof(DXD.Gamma))]
[DataContract]
public class Gamma : ColorTransformation<DXD.Gamma>
{
  /// <summary>
  /// Transforms the given color by applying the gamma transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    var gamma = 2.2;
    r = Math.Pow(r, 1.0 / gamma);
    g = Math.Pow(g, 1.0 / gamma);
    b = Math.Pow(b, 1.0 / gamma);
    var result = new EffectiveColor { RGBAComponents = (r, g, b, a) }; 
    return result;
  }
}