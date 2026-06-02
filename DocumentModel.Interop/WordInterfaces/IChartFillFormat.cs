namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents fill formatting for chart elements.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat?view=word-pia"/>
public interface IChartFillFormat : IInteropObject
{
  /// <summary>
  /// Gets the background color of the fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.backcolor?view=word-pia"/>
  public ChartColorFormat BackColor { get; }

  /// <summary>
  /// Gets the foreground color of the fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.forecolor?view=word-pia"/>
  public ChartColorFormat ForeColor { get; }

  /// <summary>
  /// Gets the gradient color type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.gradientcolortype?view=word-pia"/>
  public Core.GradientColorType GradientColorType { get; }

  /// <summary>
  /// Gets the gradient degree.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.gradientdegree?view=word-pia"/>
  public float GradientDegree { get; }

  /// <summary>
  /// Gets the gradient style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.gradientstyle?view=word-pia"/>
  public Core.GradientStyle GradientStyle { get; }

  /// <summary>
  /// Gets the gradient variant.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.gradientvariant?view=word-pia"/>
  public int GradientVariant { get; }

  /// <summary>
  /// Gets the fill pattern.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.pattern?view=word-pia"/>
  public Core.PatternType Pattern { get; }

  /// <summary>
  /// Gets the preset gradient type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.presetgradienttype?view=word-pia"/>
  public Core.PresetGradientType PresetGradientType { get; }

  /// <summary>
  /// Gets the preset texture.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.presettexture?view=word-pia"/>
  public Core.PresetTexture PresetTexture { get; }

  /// <summary>
  /// Gets the name of the custom texture file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.texturename?view=word-pia"/>
  public string TextureName { get; }

  /// <summary>
  /// Gets the texture type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.texturetype?view=word-pia"/>
  public Core.TextureType TextureType { get; }

  /// <summary>
  /// Gets the fill type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.type?view=word-pia"/>
  public Core.FillType Type { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the fill is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.visible?view=word-pia"/>
  public Core.TriState Visible { get; set; }


  #region methods

/// <summary>
  /// Executes the one color gradient operation.
  /// </summary>
  /// <param name="Style">Specifies the style.</param>
  /// <param name="Variant">Specifies the variant.</param>
  /// <param name="Degree">Specifies the degree.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartfillformat.onecolorgradient?view=word-pia"/>
  public void OneColorGradient(Core.GradientStyle Style, int Variant, float Degree);

  #endregion methods
}
