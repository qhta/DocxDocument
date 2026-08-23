namespace DocumentModel.Drawings;
/// <summary>
/// Represents a tint color transformation for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.Tint))]
[DataContract]
public class Tint : PercentageTransformation<DXD.Tint>
{
  /// <summary>
  /// Transforms the given color by applying the tint transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    var tint = Value.AsDouble();
    l = l * tint + (1 - tint);
    l = l.Clamp01();
    var result = new EffectiveColor { HSLAComponents = (h, s, l, a) };
    return result;
  }
}