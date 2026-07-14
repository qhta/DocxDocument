namespace DocumentModel.Drawings;
using Math = System.Math;


/// <summary>
/// Transforms the Blue component of the color based on the specified percentage value.
/// </summary>
[OpenXmlType(typeof(DXD.Blue))]
[DataContract]
public class Blue: PercentageTransformation<DXD.Blue>
{
  /// <summary>
  /// Transforms the given color by applying the Blue transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    b = Value.AsDouble();
    b = Math.Clamp(b, 0.0, 1.0);
    return new EffectiveColor( new Percentage(r), new Percentage(g), new Percentage(b), new Percentage(a) );
  }
}


/// <summary>
/// Specifies a more or less blue version of its input color.
/// Increases or decreases the input Blue percentage by the specified percentage offset. A 10% Blue offset increases a 50% blue to 60%.
/// A -10% Blue offset decreases a 50% blue to 40%.
/// The transformed Blue values are limited to a range of 0 to 100%. A
/// 10% Blue offset increase to a 100% blue object still results in 100% blue.
/// </summary>
[OpenXmlType(typeof(DXD.BlueOffset))]
[DataContract]
public class BlueOffset : PercentageTransformation<DXD.BlueOffset>
{
  /// <summary>
  /// Transforms the given color by applying the Blue transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    b += Value.AsDouble();
    b = Math.Clamp(b, 0.0, 1.0);
    return new EffectiveColor( new Percentage(r), new Percentage(g), new Percentage(b), new Percentage(a) );
  }
}
/// <summary>
/// Specifies a more or less blue version of its input color.
/// Increases or decreases the input Blue percentage by the specified percentage offset. A 10% Blue offset increases a 50% blue to 60%.
/// A -10% Blue offset decreases a 50% blue to 40%.
/// The transformed Blue values are limited to a range of 0 to 100%. A
/// 10% Blue offset increase to a 100% blue object still results in 100% blue.
/// </summary>
[OpenXmlType(typeof(DXD.BlueModulation))]
[DataContract]
public class BlueModulation : PercentageTransformation<DXD.BlueModulation>
{
  /// <summary>
  /// Transforms the given color by applying the Blue transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    b *= Value.AsDouble();
    b = Math.Clamp(b, 0.0, 1.0);
    return new EffectiveColor( new Percentage(r), new Percentage(g), new Percentage(b), new Percentage(a) );
  }
}