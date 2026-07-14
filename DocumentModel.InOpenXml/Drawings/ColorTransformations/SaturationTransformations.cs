namespace DocumentModel.Drawings;
using Math = System.Math;


/// <summary>
/// Transforms the Saturation component of the color based on the specified percentage value.
/// </summary>
[OpenXmlType(typeof(DXD.Saturation))]
[DataContract]
public class Saturation: PercentageTransformation<DXD.Saturation>
{
  /// <summary>
  /// Transforms the given color by applying the Saturation transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    s = Value.AsDouble();
    s = Math.Clamp(s, 0.0, 1.0);
    return new EffectiveColor( new Degrees(h * 360), s, l, a );
  }
}


/// <summary>
/// Specifies a more or less saturated version of its input color.
/// Increases or decreases the input Saturation percentage by the specified percentage offset. A 10% Saturation offset increases a 50% saturation to 60%.
/// A -10% Saturation offset decreases a 50% saturation to 40%.
/// The transformed Saturation values are limited to a range of 0 to 100%. A
/// 10% Saturation offset increase to a 100% saturation object still results in 100% saturation.
/// </summary>
[OpenXmlType(typeof(DXD.SaturationOffset))]
[DataContract]
public class SaturationOffset : PercentageTransformation<DXD.SaturationOffset>
{
  /// <summary>
  /// Transforms the given color by applying the Saturation transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    s += Value.AsDouble();
    s = Math.Clamp(s, 0.0, 1.0);
    return new EffectiveColor( new Degrees(h * 360), s, l, a );
  }
}
/// <summary>
/// Specifies a more or less saturated version of its input color.
/// Increases or decreases the input Saturation percentage by the specified percentage offset. A 10% Saturation offset increases a 50% saturation to 60%.
/// A -10% Saturation offset decreases a 50% saturation to 40%.
/// The transformed Saturation values are limited to a range of 0 to 100%. A
/// 10% Saturation offset increase to a 100% saturation object still results in 100% saturation.
/// </summary>
[OpenXmlType(typeof(DXD.SaturationModulation))]
[DataContract]
public class SaturationModulation : PercentageTransformation<DXD.SaturationModulation>
{
  /// <summary>
  /// Transforms the given color by applying the Saturation transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    s *= Value.AsDouble();
    s = Math.Clamp(s, 0.0, 1.0);
    return new EffectiveColor( new Degrees(h * 360), s, l, a );
  }
}