namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents fill formatting for a shape. A shape can have a solid, gradient, texture, pattern, picture, or semi-transparent fill.
/// </summary>
public partial interface FillFormat : InteropObject
{
  /// <summary>
  /// The back color.
  /// </summary>
  public ColorFormat BackColor { get; }

  /// <summary>
  /// The fore color.
  /// </summary>
  public ColorFormat ForeColor { get; }

  /// <summary>
  /// The gradient color type.
  /// </summary>
  public Core.MsoGradientColorType GradientColorType { get; }

  /// <summary>
  /// The gradient degree.
  /// </summary>
  public float GradientDegree { get; }

  /// <summary>
  /// The gradient style.
  /// </summary>
  public Core.MsoGradientStyle GradientStyle { get; }

  /// <summary>
  /// The gradient variant.
  /// </summary>
  public int GradientVariant { get; }

  /// <summary>
  /// The pattern.
  /// </summary>
  public Core.MsoPatternType Pattern { get; }

  /// <summary>
  /// The preset gradient type.
  /// </summary>
  public Core.MsoPresetGradientType PresetGradientType { get; }

  /// <summary>
  /// The preset texture.
  /// </summary>
  public Core.MsoPresetTexture PresetTexture { get; }

  /// <summary>
  /// The texture name.
  /// </summary>
  public string TextureName { get; }

  /// <summary>
  /// The texture type.
  /// </summary>
  public Core.MsoTextureType TextureType { get; }

  /// <summary>
  /// The transparency.
  /// </summary>
  public float Transparency { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public Core.MsoFillType Type { get; }

  /// <summary>
  /// The visible.
  /// </summary>
  public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// The gradient stops.
  /// </summary>
  public Core.GradientStops GradientStops { get; }

  /// <summary>
  /// The texture offset x.
  /// </summary>
  public float TextureOffsetX { get; set; }

  /// <summary>
  /// The texture offset y.
  /// </summary>
  public float TextureOffsetY { get; set; }

  /// <summary>
  /// The texture alignment.
  /// </summary>
  public Core.MsoTextureAlignment TextureAlignment { get; set; }

  /// <summary>
  /// The texture horizontal scale.
  /// </summary>
  public float TextureHorizontalScale { get; set; }

  /// <summary>
  /// The texture vertical scale.
  /// </summary>
  public float TextureVerticalScale { get; set; }

  /// <summary>
  /// The texture tile.
  /// </summary>
  public Core.MsoTriState TextureTile { get; set; }

  /// <summary>
  /// The rotate with object.
  /// </summary>
  public Core.MsoTriState RotateWithObject { get; set; }

  /// <summary>
  /// The picture effects.
  /// </summary>
  public Core.PictureEffects PictureEffects { get; }

  /// <summary>
  /// The gradient angle.
  /// </summary>
  public float GradientAngle { get; set; }
}
