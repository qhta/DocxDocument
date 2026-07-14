using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Drawings;

using Math = System.Math;

/// <summary>
/// Represents an gray color transformation for drawing elements. each RGB component is inverted (i.e., 1.0 - component value) to produce the gray color.
/// </summary>
[OpenXmlType(typeof(DXD.Gray))]
[DataContract]
public class Gray : ColorTransformation<DXD.Gray>
{
  /// <summary>
  /// Transforms the given color by applying the gray transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    var gray = r * 0.3 + g * 0.59 + b * 0.11;
    var result = new EffectiveColor { RGBAComponents = (gray, gray, gray, a) }; 
    return result;
  }
}