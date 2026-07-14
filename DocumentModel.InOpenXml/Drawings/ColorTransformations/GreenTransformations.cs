namespace DocumentModel.Drawings;
using Math = System.Math;


/// <summary>
/// Transforms the Green component of the color based on the specified percentage value.
/// </summary>
[OpenXmlType(typeof(DXD.Green))]
[DataContract]
public class Green: PercentageTransformation<DXD.Green>
{
  /// <summary>
  /// Transforms the given color by applying the Green transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    g = Value.AsDouble();
    g = Math.Clamp(g, 0.0, 1.0);
    return new EffectiveColor( new Percentage(r), new Percentage(g), new Percentage(b), new Percentage(a) );
  }
}


/// <summary>
/// Specifies a more or less green version of its input color.
/// Increases or decreases the input Green percentage by the specified percentage offset. A 10% Green offset increases a 50% green to 60%.
/// A -10% Green offset decreases a 50% green to 40%.
/// The transformed Green values are limited to a range of 0 to 100%. A
/// 10% Green offset increase to a 100% green object still results in 100% green.
/// </summary>
[OpenXmlType(typeof(DXD.GreenOffset))]
[DataContract]
public class GreenOffset : PercentageTransformation<DXD.GreenOffset>
{
  /// <summary>
  /// Transforms the given color by applying the Green transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    g += Value.AsDouble();
    g = Math.Clamp(g, 0.0, 1.0);
    return new EffectiveColor( new Percentage(r), new Percentage(g), new Percentage(b), new Percentage(a) );
  }
}
/// <summary>
/// Specifies a more or less green version of its input color.
/// Increases or decreases the input Green percentage by the specified percentage offset. A 10% Green offset increases a 50% green to 60%.
/// A -10% Green offset decreases a 50% green to 40%.
/// The transformed Green values are limited to a range of 0 to 100%. A
/// 10% Green offset increase to a 100% green object still results in 100% green.
/// </summary>
[OpenXmlType(typeof(DXD.GreenModulation))]
[DataContract]
public class GreenModulation : PercentageTransformation<DXD.GreenModulation>
{
  /// <summary>
  /// Transforms the given color by applying the Green transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    g *= Value.AsDouble();
    g = Math.Clamp(g, 0.0, 1.0);
    return new EffectiveColor( new Percentage(r), new Percentage(g), new Percentage(b), new Percentage(a) );
  }
}