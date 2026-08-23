namespace DocumentModel.Drawings;

using Math = System.Math;

/// <summary>
/// Represents an inverse gamma color transformation for drawing elements.
/// Applies inverse gamma correction to convert from 
/// display-corrected RGB to linear RGB space.
/// </summary>
[OpenXmlType(typeof(DXD.InverseGamma))]
[DataContract]
public class InverseGamma : ColorTransformation<DXD.InverseGamma>
{
  /// <summary>
  /// Transforms the given color by applying the inversegamma transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    var gamma = 2.2;
    r = Math.Pow(r, gamma);
    g = Math.Pow(g, gamma);
    b = Math.Pow(b, gamma);
    var result = new EffectiveColor { RGBAComponents = (r, g, b, a) };
    return result;
  }
}