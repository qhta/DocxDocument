using DocumentFormat.OpenXml.Office2010.Excel;

namespace DocumentModel.Wordprocessing;

public partial class WordDrawingsColorBase<T> : ITintableColor, ITransformableColor
{

  double? ITintableColor.Tint { get => this.Tint; set => this.Tint = value; }

  double? ITintableColor.Shade { get => this.Shade; set => this.Shade = value; }

  /// <summary>
  /// Gets the effective color after applying any tint or shade transformations.
  /// </summary>
  /// <returns>The effective color after applying transformations.</returns>
  public override IColor GetEffectiveColor()
  {
    IColor result = this;
    if (Tint is not null)
      result = new DMD.Tint { Value = Tint.Value }.Transform(result);
    if (Shade is not null)
      result = new DMD.Shade { Value = Shade.Value }.Transform(result);
    return result;
  }

  /// <summary>
  /// Gets tint and shade transformations as a list of IColorTransformation objects.
  /// </summary>
  /// <returns></returns>
  public override IEnumerable<IColorTransformation> GetTransformations()
  {
    var transformations = new List<IColorTransformation>();
    if (Tint is not null)
      transformations.Add(new DMD.Tint { Value = Tint.Value });
    if (Shade is not null)
      transformations.Add(new DMD.Shade { Value = Shade.Value });
    return transformations;
  }

  /// <summary>
  /// Adds a color transformation to the current color. If the transformation is a Tint or Shade, it updates the corresponding property and returns true; otherwise, it returns false.
  /// </summary>
  /// <param name="transformation">The color transformation to add.</param>
  /// <returns>True if the transformation was added; otherwise, false.</returns>
  public override bool AddTransformation(IColorTransformation transformation)
  {
    if (_supportedTransformations.Contains(transformation.GetType()) && transformation is DMD.ColorTransformation colorTransformation)
    {
      ColorTransformations.Add(colorTransformation);
      return true;
    }
    return false;
  }

  private static readonly Type[] _supportedTransformations =
  [
    typeof(DMD.Tint), 
    typeof(DMD.Shade),
    typeof(DMD.Alpha),
    typeof(DMD.HueModulation),
    typeof(DMD.Saturation),
    typeof(DMD.SaturationOffset),
    typeof(DMD.SaturationModulation),
    typeof(DMD.Luminance),
    typeof(DMD.LuminanceOffset),
    typeof(DMD.LuminanceModulation),

  ];
}
