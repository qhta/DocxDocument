namespace DocumentModel.Interop;

/// <summary>
/// Represents fill formatting for chart elements.
/// </summary>
public partial interface ChartFillFormat : InteropObject
{
  /// <summary>
  /// The back color.
  /// </summary>
  public ChartColorFormat BackColor { get; }

  /// <summary>
  /// The fore color.
  /// </summary>
  public ChartColorFormat ForeColor { get; }

  /// <summary>
  /// The gradient color type.
  /// </summary>
  //public Core.MsoGradientColorType GradientColorType { get; }

  /// <summary>
  /// The gradient degree.
  /// </summary>
  public float GradientDegree { get; }

  /// <summary>
  /// The gradient style.
  /// </summary>
  //public Core.MsoGradientStyle GradientStyle { get; }

  /// <summary>
  /// The gradient variant.
  /// </summary>
  public int GradientVariant { get; }

  /// <summary>
  /// The pattern.
  /// </summary>
  //public Core.MsoPatternType Pattern { get; }

  /// <summary>
  /// The preset gradient type.
  /// </summary>
  //public Core.MsoPresetGradientType PresetGradientType { get; }

  /// <summary>
  /// The preset texture.
  /// </summary>
  //public Core.MsoPresetTexture PresetTexture { get; }

  /// <summary>
  /// The texture name.
  /// </summary>
  public string TextureName { get; }

  /// <summary>
  /// The texture type.
  /// </summary>
  //public Core.MsoTextureType TextureType { get; }

  /// <summary>
  /// The type.
  /// </summary>
  //public Core.MsoFillType Type { get; }

  /// <summary>
  /// The visible.
  /// </summary>
  //public Core.MsoTriState Visible { get; set; }
}
