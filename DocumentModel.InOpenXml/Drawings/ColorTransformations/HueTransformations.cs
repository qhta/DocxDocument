namespace DocumentModel.Drawings;

using Math = System.Math;


/// <summary>
/// Transforms the Hue component of the color based on the specified degrees value.
/// </summary>
[OpenXmlType(typeof(DXD.Hue))]
[DataContract]
public class Hue : DegreesTransformation<DXD.Hue>
{
  /// <summary>
  /// Transforms the given color by applying the Hue transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    h = Value.AsDouble();
    h = Math.Clamp(h, 0.0, 1.0);
    return new EffectiveColor(new Degrees(h * 360), s, l, a);
  }
}


/// <summary>
/// Increases or decreases the input Hue percentage by the specified percentage offset. A 10% Hue offset increases a 50% hue to 60%.
/// A -10% Hue offset decreases a 50% hue to 40%.
/// The transformed Hue values are limited to a range of 0 to 100%. A
/// 10% Hue offset increase to a 100% hue object still results in 100% hue.
/// </summary>
[OpenXmlType(typeof(DXD.HueOffset))]
[DataContract]
public class HueOffset : DegreesTransformation<DXD.HueOffset>
{
  /// <summary>
  /// Transforms the given color by applying the Hue transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    h += Value.AsDouble();
    h = Math.Clamp(h, 0.0, 1.0);
    return new EffectiveColor(new Degrees(h * 360), s, l, a);
  }
}
/// <summary>
/// Increases or decreases the input Hue percentage by the specified percentage offset. A 10% Hue offset increases a 50% hue to 60%.
/// A -10% Hue offset decreases a 50% hue to 40%.
/// The transformed Hue values are limited to a range of 0 to 100%. A
/// 10% Hue offset increase to a 100% hue object still results in 100% hue.
/// </summary>
[OpenXmlType(typeof(DXD.HueModulation))]
[DataContract]
public class HueModulation : PercentageTransformation<DXD.HueModulation>
{
  /// <summary>
  /// Transforms the given color by applying the Hue transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    h *= Value.AsDouble();
    h = Math.Clamp(h, 0.0, 1.0);
    return new EffectiveColor(new Degrees(h * 360), s, l, a);
  }
}