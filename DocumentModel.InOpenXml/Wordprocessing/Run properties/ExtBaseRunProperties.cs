using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing;
/// <summary>
/// Extended base interface for run properties, containing additional character-level formatting properties not applied to <see cref = "BaseRunProperties{T}"/>.
/// Includes support for complex script, right-to-left text, highlighting, OpenType features, and Office 2010+ advanced effects.
/// </summary>
public partial class ExtBaseRunProperties<T>: BaseRunProperties<T> where T: DX.OpenXmlCompositeElement
{
  #region These properties are defined in ECMA
  /// <summary>
  /// Style ID of the character style used to format the contents of this paragraph.
  /// </summary>
  public string? RunStyle { get; set; }
  /// <summary>
  /// Indicates whether the run contents are treated as complex script text regardless of Unicode values.
  /// </summary>
  public bool? ComplexScript { get; set; }
  /// <summary>
  /// Indicates whether the run contents have right-to-left characteristics.
  /// </summary>
  public bool? RightToLeftText { get; set; }
  /// <summary>
  /// Highlighting color applied as a background behind the run contents. Supersedes shading when displayed.
  /// </summary>
  public HighlightColors? Highlight { get; set; }
  #endregion
  #region These properties are defined in Office Word Extensions (from Office 2010)
  /// <summary>
  /// Indicates whether to display characters using contextual alternates according to OpenType TextFormat specification.
  /// </summary>
  public Boolean? ContextualAlternates { get; set; }
  /// <summary>
  /// Glow effect, a colored, blurred outline added outside the edges of text.
  /// </summary>
  public DMWD.Glow? Glow { get; set; }
  /// <summary>
  /// Shadow effect for the run (Office 2010+).
  /// </summary>
  public DMWD.Shadow? Shadow14 { get; set; }
  /// <summary>
  /// 3-D reflection properties for the run (Office 2010+).
  /// </summary>
  public DMWD.Reflection? Reflection { get; set; }
  /// <summary>
  /// Text outline effect for the run (Office 2010+).
  /// </summary>
  public DMWD.TextOutlineEffect? TextOutlineEffect { get; set; }
  /// <summary>
  /// Text fill effect for the run (Office 2010+).
  /// </summary>
  public DMWD.FillTextEffect? FillTextEffect { get; set; }
  /// <summary>
  /// 3D scene properties for the run (Office 2010+).
  /// </summary>
  public DMWD.Scene3D? Scene3D { get; set; }
  /// <summary>
  /// 3D text properties for the run (Office 2010+).
  /// </summary>
  public DMWD.Properties3D? Properties3D { get; set; }
  /// <summary>
  /// Specifies which kinds of ligatures to use when displaying the text.
  /// </summary>
  public Ligatures? Ligatures { get; set; }
  /// <summary>
  /// Number form for OpenType fonts, specifies lining or old-style numerals.
  /// </summary>
  public NumberForm? NumberingFormat { get; set; }
  /// <summary>
  /// Number spacing for OpenType fonts, specifies proportional or tabular spacing for numbers.
  /// </summary>
  public NumberSpacing? NumberSpacing { get; set; }
  /// <summary>
  /// Stylistic sets collection for OpenType fonts, enabling alternate glyph sets.
  /// </summary>
  public StylisticSets? StylisticSets { get; set; }
  #endregion
}