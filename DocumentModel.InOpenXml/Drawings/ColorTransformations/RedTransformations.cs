namespace DocumentModel.Drawings;

using Math = System.Math;


/// <summary>
/// Transforms Red component of the color based on the specified percentage value.
/// </summary>
[OpenXmlType(typeof(DXD.Red))]
[DataContract]
public class Red : PercentageTransformation<DXD.Red>
{
  /// <summary>
  /// Transforms the given color by applying the Red transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    r = Value.AsDouble();
    r = Math.Clamp(r, 0.0, 1.0);
    return new EffectiveColor( new Percentage(r), new Percentage(g), new Percentage(b), new Percentage(a) );
  }
}


/// <summary>
/// Specifies a more or less red version of its input color.
/// Increases or decreases the input Red percentage by the specified percentage offset. A 10% Red offset increases a 50% red to 60%.
/// A -10% Red offset decreases a 50% red to 40%.
/// The transformed Red values are limited to a range of 0 to 100%. A
/// 10% Red offset increase to a 100% red object still results in 100% red.
/// </summary>
[OpenXmlType(typeof(DXD.RedOffset))]
[DataContract]
public class RedOffset : PercentageTransformation<DXD.RedOffset>
{
  /// <summary>
  /// Transforms the given color by applying the Red transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    r += Value.AsDouble();
    r = Math.Clamp(r, 0.0, 1.0);
    return new EffectiveColor( new Percentage(r), new Percentage(g), new Percentage(b), new Percentage(a) );
  }
}
/// <summary>
/// Specifies a more or less red version of its input color.
/// Increases or decreases the input Red percentage by the specified percentage offset. A 10% Red offset increases a 50% red to 60%.
/// A -10% Red offset decreases a 50% red to 40%.
/// The transformed Red values are limited to a range of 0 to 100%. A
/// 10% Red offset increase to a 100% red object still results in 100% red.
/// </summary>
[OpenXmlType(typeof(DXD.RedModulation))]
[DataContract]
public class RedModulation : PercentageTransformation<DXD.RedModulation>
{
  /// <summary>
  /// Transforms the given color by applying the Red transformation based on the specified value.
  /// </summary>
  /// <param name="color">The color to be transformed.</param>
  /// <returns>The transformed color.</returns>
  public override IColor Transform(IColor color)
  {
    var (r, g, b, a) = color.RGBAComponents;
    r *= Value.AsDouble();
    r = Math.Clamp(r, 0.0, 1.0);
    return new EffectiveColor( new Percentage(r), new Percentage(g), new Percentage(b), new Percentage(a) );
  }
}