namespace DocumentModel.Drawings;
using Math = System.Math;


/// <summary>
/// Specifies that the defined color has a specific opacity (as a positive fixed percentage), but with its color unchanged.
/// </summary>
[OpenXmlType(typeof(DXD.Alpha))]
public class Alpha: PercentageTransformation<DXD.Alpha>
{
  /// <summary>
  /// Transforms the given color by applying the alpha transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, _) = color.RGBAComponents;
    var a = Value / 100.0;
    a = Math.Clamp(a, 0.0, 1.0);
    return new RgbColorModelPercentage() { R = r, G = g, B = b, A = a };
  }
}


/// <summary>
/// Specifies a more or less opaque version of its input color.
/// Increases or decreases the input alpha percentage by the specified percentage offset. A 10% alpha offset increases a 50% opacity to 60%.
/// A -10% alpha offset decreases a 50% opacity to 40%.
/// The transformed alpha values are limited to a range of 0 to 100%. A
/// 10% alpha offset increase to a 100% opaque object still results in 100% opacity.
/// </summary>
[OpenXmlType(typeof(DXD.AlphaOffset))]
public class AlphaOffset : PercentageTransformation<DXD.AlphaOffset>
{
  /// <summary>
  /// Transforms the given color by applying the alpha transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    a += Value / 100.0;
    a = Math.Clamp(a, 0.0, 1.0);
    return new RgbColorModelPercentage() { R = r, G = g, B = b, A = a };
  }
}
/// <summary>
/// Specifies a more or less opaque version of its input color.
/// Increases or decreases the input alpha percentage by the specified percentage offset. A 10% alpha offset increases a 50% opacity to 60%.
/// A -10% alpha offset decreases a 50% opacity to 40%.
/// The transformed alpha values are limited to a range of 0 to 100%. A
/// 10% alpha offset increase to a 100% opaque object still results in 100% opacity.
/// </summary>
[OpenXmlType(typeof(DXD.AlphaModulation))]
public class AlphaModulation : PercentageTransformation<DXD.AlphaModulation>
{
  /// <summary>
  /// Transforms the given color by applying the alpha transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    a += Value / 100.0;
    a = Math.Clamp(a, 0.0, 1.0);
    return new RgbColorModelPercentage() { R = r, G = g, B = b, A = a };
  }
}