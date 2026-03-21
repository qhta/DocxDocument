namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents fill formatting for chart elements.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat?view=word-pia"/>
public partial interface ChartFillFormat : InteropObject
{
  /// <summary>
  /// The back color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.backcolor?view=word-pia"/>
  public ChartColorFormat BackColor { get; }

  /// <summary>
  /// The fore color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.forecolor?view=word-pia"/>
  public ChartColorFormat ForeColor { get; }

  /// <summary>
  /// The gradient color type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.gradientcolortype?view=word-pia"/>
  public Core.MsoGradientColorType GradientColorType { get; }

  /// <summary>
  /// The gradient degree.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.gradientdegree?view=word-pia"/>
  public float GradientDegree { get; }

  /// <summary>
  /// The gradient style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.gradientstyle?view=word-pia"/>
  public Core.MsoGradientStyle GradientStyle { get; }

  /// <summary>
  /// The gradient variant.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.gradientvariant?view=word-pia"/>
  public int GradientVariant { get; }

  /// <summary>
  /// The pattern.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.pattern?view=word-pia"/>
  public Core.MsoPatternType Pattern { get; }

  /// <summary>
  /// The preset gradient type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.presetgradienttype?view=word-pia"/>
  public Core.MsoPresetGradientType PresetGradientType { get; }

  /// <summary>
  /// The preset texture.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.presettexture?view=word-pia"/>
  public Core.MsoPresetTexture PresetTexture { get; }

  /// <summary>
  /// The texture name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.texturename?view=word-pia"/>
  public string TextureName { get; }

  /// <summary>
  /// The texture type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.texturetype?view=word-pia"/>
  public Core.MsoTextureType TextureType { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.type?view=word-pia"/>
  public Core.MsoFillType Type { get; }

  /// <summary>
  /// The visible.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.visible?view=word-pia"/>
  public Core.MsoTriState Visible { get; set; }
}
