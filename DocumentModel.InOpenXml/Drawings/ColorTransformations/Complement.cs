using DocumentModel.Drawings.Diagrams;

namespace DocumentModel.Drawings;

using Math = System.Math;

/// <summary>
/// Represents a complement color transformation for drawing elements. Hue is shifted by 180 degrees to produce the complementary color.
/// </summary>
[OpenXmlType(typeof(DXD.Complement))]
[DataContract]
public class Complement : ColorTransformation<DXD.Complement>
{
  /// <summary>
  /// Transforms the given color by applying the complement transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    h = (h + 0.5) % 1.0; // Shift hue by 180 degrees to get the complement
    var result = new EffectiveColor { HSLAComponents = (h, s, l, a) }; 
    return result;
  }
}