namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base class for RunProperties classes.
///   Contains  these common properties, which are not applied to <see cref="BaseRunProperties"/>
/// </summary>
public abstract class ExtendedRunPropertiesBase : BaseRunProperties
{
  #region These properties are defined in ECMA
  /// <summary>
  ///   Specifies the style ID of the character style which shall be used to format the contents of this paragraph.
  /// </summary>
  public String? RunStyle { get; set; }

  /// <summary>
  ///   Specifies whether the contents of this run shall be treated as complex script text regardless of their Unicode character values when determining the formatting for this run. 
  /// </summary>
  public Boolean? ComplexScript { get; set; }

  /// <summary>
  ///   Specifies whether the contents of this run shall have right-to-left characteristics.
  /// </summary>
  public Boolean? RightToLeftText { get; set; }

  /// <summary>
  ///   Specifies a highlighting color which is applied as a background behind the contents of this run. 
  ///   If this run has any background shading specified using the shading, 
  ///   then the background shading shall be superseded by the highlighting color when the contents of this run are displayed. 
  ///   This property is not applied to <see cref="BaseRunProperties"/> element.
  /// </summary>
  public HighlightColorKind? Highlight { get; set; }

  #endregion

  #region These properties are defined in Office Word Extensions (from Office 2010)

  /// <summary>
  ///   Specifies whether to display the characters using contextual alternates according to OpenType Font specification.
  /// </summary>
  public OnOffKind? ContextualAlternates { get; set; }

  /// <summary>
  ///   Specifies the glow effect, a colored, blurred outline that is added outside the edges of text.
  /// </summary>
  public Glow? Glow { get; set; }

  /// <summary>
  ///   Specifies the shadow effect.
  /// </summary>
  public Shadow2? Shadow14 { get; set; }

  /// <summary>
  ///   Specifies the 3-D properties of text, including bevel, extrusion, contour, and material.
  /// </summary>
  public Reflection? Reflection { get; set; }

  /// <summary>
  ///   TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public TextOutlineEffect? TextOutlineEffect { get; set; }

  /// <summary>
  ///   FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public FillTextEffect? FillTextEffect { get; set; }

  /// <summary>
  ///   Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  public Scene3D? Scene3D { get; set; }

  /// <summary>
  ///   Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  public Properties3D? Properties3D { get; set; }

  /// <summary>
  ///   Specifies which kinds of ligatures to use when displaying the text.
  /// </summary>
  public LigaturesKind? Ligatures { get; set; }

  /// <summary>
  ///   NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  public NumberFormKind? NumberingFormat { get; set; }

  /// <summary>
  ///   NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  public NumberSpacingKind? NumberSpacing { get; set; }

  /// <summary>
  ///   StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  public StylisticSets? StylisticSets { get; set; }
  #endregion
}