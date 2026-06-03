namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents fill formatting for a shape. A shape can have a solid, gradient, texture, pattern, picture, or semi-transparent fill.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat?view=word-pia"/>
public partial class FillFormat : InteropObject
{
  /// <summary>
  /// Returns or sets a <see cref="ColorFormat"/> object that represents the background color for the specified fill or patterned line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.backcolor?view=word-pia"/>
  public ColorFormat BackColor { get; set; }

  /// <summary>
  /// Returns or sets a <see cref="ColorFormat"/> object that represents the foreground color for the fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.forecolor?view=word-pia"/>
  public ColorFormat ForeColor { get; set; }

  /// <summary>
  /// Returns the gradient color type for the specified fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientcolortype?view=word-pia"/>
  public Core.GradientColorType GradientColorType { get; set; }

  /// <summary>
  /// Returns a value that indicates how dark or light a one-color gradient fill is.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientdegree?view=word-pia"/>
  public float GradientDegree { get; set; }

  /// <summary>
  /// Returns the gradient style for the specified fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientstyle?view=word-pia"/>
  public Core.GradientStyle GradientStyle { get; set; }

  /// <summary>
  /// Returns the gradient variant for the specified fill as an integer value from 1 to 4 for most gradient fills.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientvariant?view=word-pia"/>
  public int GradientVariant { get; set; }

  /// <summary>
  /// Returns a value that represents the pattern applied to the specified fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.pattern?view=word-pia"/>
  public Core.PatternType Pattern { get; set; }

  /// <summary>
  /// Returns the preset gradient type for the specified fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.presetgradienttype?view=word-pia"/>
  public Core.PresetGradientType PresetGradientType { get; set; }

  /// <summary>
  /// Returns the preset texture for the specified fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.presettexture?view=word-pia"/>
  public Core.PresetTexture PresetTexture { get; set; }

  /// <summary>
  /// Returns the name of the custom texture file for the specified fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.texturename?view=word-pia"/>
  public string? TextureName { get; set; }

  /// <summary>
  /// Returns the texture type for the specified fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.texturetype?view=word-pia"/>
  public Core.TextureType TextureType { get; set; }

  /// <summary>
  /// Returns or sets the degree of transparency of the specified fill as a value between 0.0 (opaque) and 1.0 (clear).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.transparency?view=word-pia"/>
  public float Transparency { get; set; }

  /// <summary>
  /// Returns the shape fill format type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.type?view=word-pia"/>
  public Core.FillType Type { get; set; }

  /// <summary>
  /// Returns whether the specified object, or the formatting applied to it, is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.visible?view=word-pia"/>
  public Core.TriState Visible { get; set; }

  /// <summary>
  /// Gets the <see cref="Core.GradientStops"/> collection associated with the specified fill format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientstops?view=word-pia"/>
  public Core.IGradientStops GradientStops { get; set; }

  /// <summary>
  /// Gets or sets a value that specifies the horizontal offset of the texture from the origin in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.textureoffsetx?view=word-pia"/>
  public float TextureOffsetX { get; set; }

  /// <summary>
  /// Gets or sets a value that specifies the vertical offset of the texture from the origin in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.textureoffsety?view=word-pia"/>
  public float TextureOffsetY { get; set; }

  /// <summary>
  /// Gets or sets the alignment (the origin of the coordinate grid) for the tiling of the texture fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.texturealignment?view=word-pia"/>
  public Core.TextureAlignment TextureAlignment { get; set; }

  /// <summary>
  /// Gets or sets a value that specifies the horizontal scaling factor for the texture fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.texturehorizontalscale?view=word-pia"/>
  public float TextureHorizontalScale { get; set; }

  /// <summary>
  /// Gets or sets a value that specifies the vertical scaling factor for the texture fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.textureverticalscale?view=word-pia"/>
  public float TextureVerticalScale { get; set; }

  /// <summary>
  /// Gets or sets whether the texture fill is tiled or centered.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.texturetile?view=word-pia"/>
  public Core.TriState TextureTile { get; set; }

  /// <summary>
  /// Gets or sets whether the fill rotates with the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.rotatewithobject?view=word-pia"/>
  public Core.TriState RotateWithObject { get; set; }

  /// <summary>
  /// Gets a <see cref="Core.PictureEffects"/> object that can be used to apply picture effects to the specified fill formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.pictureeffects?view=word-pia"/>
  public Core.IPictureEffects PictureEffects { get; set; }

  /// <summary>
  /// Gets or sets the angle of the gradient fill for the specified fill format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.gradientangle?view=word-pia"/>
  public float GradientAngle { get; set; }


  #region methods

/// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fillformat.background?view=word-pia"/>
  public void Background() { throw new NotImplementedException(); }

  #endregion methods
}
