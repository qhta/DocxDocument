namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents fill formatting for a shape. A shape can have a solid, gradient, texture, pattern, picture, or semi-transparent fill.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat?view=word-pia"/>
public partial interface FillFormat : InteropObject
{
  /// <summary>
  /// The back color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.backcolor?view=word-pia"/>
  public ColorFormat BackColor { get; }

  /// <summary>
  /// The fore color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.forecolor?view=word-pia"/>
  public ColorFormat ForeColor { get; }

  /// <summary>
  /// The gradient color type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientcolortype?view=word-pia"/>
  public Core.MsoGradientColorType GradientColorType { get; }

  /// <summary>
  /// The gradient degree.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientdegree?view=word-pia"/>
  public float GradientDegree { get; }

  /// <summary>
  /// The gradient style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientstyle?view=word-pia"/>
  public Core.MsoGradientStyle GradientStyle { get; }

  /// <summary>
  /// The gradient variant.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientvariant?view=word-pia"/>
  public int GradientVariant { get; }

  /// <summary>
  /// The pattern.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.pattern?view=word-pia"/>
  public Core.MsoPatternType Pattern { get; }

  /// <summary>
  /// The preset gradient type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.presetgradienttype?view=word-pia"/>
  public Core.MsoPresetGradientType PresetGradientType { get; }

  /// <summary>
  /// The preset texture.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.presettexture?view=word-pia"/>
  public Core.MsoPresetTexture PresetTexture { get; }

  /// <summary>
  /// The texture name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.texturename?view=word-pia"/>
  public string TextureName { get; }

  /// <summary>
  /// The texture type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.texturetype?view=word-pia"/>
  public Core.MsoTextureType TextureType { get; }

  /// <summary>
  /// The transparency.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.transparency?view=word-pia"/>
  public float Transparency { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.type?view=word-pia"/>
  public Core.MsoFillType Type { get; }

  /// <summary>
  /// The visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.visible?view=word-pia"/>
  public Core.MsoTriState Visible { get; set; }

  /// <summary>
  /// The gradient stops.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientstops?view=word-pia"/>
  public Core.GradientStops GradientStops { get; }

  /// <summary>
  /// The texture offset x.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.textureoffsetx?view=word-pia"/>
  public float TextureOffsetX { get; set; }

  /// <summary>
  /// The texture offset y.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.textureoffsety?view=word-pia"/>
  public float TextureOffsetY { get; set; }

  /// <summary>
  /// The texture alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.texturealignment?view=word-pia"/>
  public Core.MsoTextureAlignment TextureAlignment { get; set; }

  /// <summary>
  /// The texture horizontal scale.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.texturehorizontalscale?view=word-pia"/>
  public float TextureHorizontalScale { get; set; }

  /// <summary>
  /// The texture vertical scale.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.textureverticalscale?view=word-pia"/>
  public float TextureVerticalScale { get; set; }

  /// <summary>
  /// The texture tile.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.texturetile?view=word-pia"/>
  public Core.MsoTriState TextureTile { get; set; }

  /// <summary>
  /// The rotate with object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.rotatewithobject?view=word-pia"/>
  public Core.MsoTriState RotateWithObject { get; set; }

  /// <summary>
  /// The picture effects.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.pictureeffects?view=word-pia"/>
  public Core.PictureEffects PictureEffects { get; }

  /// <summary>
  /// The gradient angle.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientangle?view=word-pia"/>
  public float GradientAngle { get; set; }
}
