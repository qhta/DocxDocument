using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Drawings;

using Math = System.Math;

/// <summary>
/// Represents an inverse color transformation for drawing elements. each RGB component is inverted (i.e., 1.0 - component value) to produce the inverse color.
/// </summary>
[OpenXmlType(typeof(DXD.Inverse))]
[DataContract]
public class Inverse : ColorTransformation<DXD.Inverse>
{
  /// <summary>
  /// Transforms the given color by applying the inverse transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    r = 1.0 - r; // Invert red component
    g = 1.0 - g; // Invert green component
    b = 1.0 - b; // Invert blue component
    var result = new EffectiveColor { RGBAComponents = (r, g, b, a) }; 
    return result;
  }
}