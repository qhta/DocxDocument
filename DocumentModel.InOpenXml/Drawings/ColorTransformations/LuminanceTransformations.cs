namespace DocumentModel.Drawings;
using Math = System.Math;


/// <summary>
/// Transforms the Luminance component of the color based on the specified percentage value.
/// </summary>
[OpenXmlType(typeof(DXD.Luminance))]
[DataContract]
public class Luminance: PercentageTransformation<DXD.Luminance>
{
  /// <summary>
  /// Transforms the given color by applying the Luminance transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    l = Value.AsDouble();
    l = Math.Clamp(l, 0.0, 1.0);
    return new EffectiveColor( new Degrees(h * 360), s, l, a );
  }
}


/// <summary>
/// Specifies a more or less luminant version of its input color.
/// Increases or decreases the input Luminance percentage by the specified percentage offset. A 10% Luminance offset increases a 50% luminance to 60%.
/// A -10% Luminance offset decreases a 50% luminance to 40%.
/// The transformed Luminance values are limited to a range of 0 to 100%. A
/// 10% Luminance offset increase to a 100% luminance object still results in 100% luminance.
/// </summary>
[OpenXmlType(typeof(DXD.LuminanceOffset))]
[DataContract]
public class LuminanceOffset : PercentageTransformation<DXD.LuminanceOffset>
{
  /// <summary>
  /// Transforms the given color by applying the Luminance transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    l += Value.AsDouble();
    l = Math.Clamp(l, 0.0, 1.0);
    return new EffectiveColor( new Degrees(h * 360), s, l, a );
  }
}
/// <summary>
/// Specifies a more or less luminant version of its input color.
/// Increases or decreases the input Luminance percentage by the specified percentage offset. A 10% Luminance offset increases a 50% luminance to 60%.
/// A -10% Luminance offset decreases a 50% luminance to 40%.
/// The transformed Luminance values are limited to a range of 0 to 100%. A
/// 10% Luminance offset increase to a 100% luminance object still results in 100% luminance.
/// </summary>
[OpenXmlType(typeof(DXD.LuminanceModulation))]
[DataContract]
public class LuminanceModulation : PercentageTransformation<DXD.LuminanceModulation>
{
  /// <summary>
  /// Transforms the given color by applying the Luminance transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (h, s, l, a) = color.HSLAComponents;
    l *= Value.AsDouble();
    l = Math.Clamp(l, 0.0, 1.0);
    return new EffectiveColor( new Degrees(h * 360), s, l, a );
  }
}