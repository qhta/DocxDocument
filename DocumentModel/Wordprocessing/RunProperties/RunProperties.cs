namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Run Properties.
/// </summary>
public class RunProperties: ModelElement
{
  /// <summary>
  ///   RunStyle.
  /// </summary>
  public String? RunStyle { get; set; }

  /// <summary>
  ///   RunFonts.
  /// </summary>
  public RunFonts? RunFonts { get; set; }

  /// <summary>
  ///   Bold.
  /// </summary>
  public Boolean? Bold { get; set; }

  /// <summary>
  ///   BoldComplexScript.
  /// </summary>
  public Boolean? BoldCS { get; set; }

  /// <summary>
  ///   Italic.
  /// </summary>
  public Boolean? Italic { get; set; }

  /// <summary>
  ///   ItalicComplexScript.
  /// </summary>
  public Boolean? ItalicCS { get; set; }

  /// <summary>
  ///   Caps.
  /// </summary>
  public Boolean? Caps { get; set; }

  /// <summary>
  ///   SmallCaps.
  /// </summary>
  public Boolean? SmallCaps { get; set; }

  /// <summary>
  ///   Strike.
  /// </summary>
  public Boolean? Strike { get; set; }

  /// <summary>
  ///   DoubleStrike.
  /// </summary>
  public Boolean? DoubleStrike { get; set; }

  /// <summary>
  ///   Outline.
  /// </summary>
  public Boolean? Outline { get; set; }

  /// <summary>
  ///   Shadow.
  /// </summary>
  public Boolean? Shadow { get; set; }

  /// <summary>
  ///   Emboss.
  /// </summary>
  public Boolean? Emboss { get; set; }

  /// <summary>
  ///   Imprint.
  /// </summary>
  public Boolean? Imprint { get; set; }

  /// <summary>
  ///   NoProof.
  /// </summary>
  public Boolean? NoProof { get; set; }

  /// <summary>
  ///   SnapToGrid.
  /// </summary>
  public Boolean? SnapToGrid { get; set; }

  /// <summary>
  ///   Vanish.
  /// </summary>
  public Boolean? Vanish { get; set; }

  /// <summary>
  ///   WebHidden.
  /// </summary>
  public Boolean? WebHidden { get; set; }

  /// <summary>
  ///   Color.
  /// </summary>
  public Color? Color { get; set; }

  /// <summary>
  ///   Spacing.
  /// </summary>
  public Int32? Spacing { get; set; }

  /// <summary>
  ///   CharacterScale.
  /// </summary>
  public Int64? CharacterScale { get; set; }

  /// <summary>
  ///   Kern.
  /// </summary>
  public UInt32? Kern { get; set; }

  /// <summary>
  ///   Position.
  /// </summary>
  public String? Position { get; set; }

  /// <summary>
  ///   FontSize.
  /// </summary>
  public String? FontSize { get; set; }

  /// <summary>
  ///   FontSizeComplexScript.
  /// </summary>
  public String? FontSizeCS { get; set; }

  /// <summary>
  ///   Highlight.
  /// </summary>
  public HighlightColorKind? Highlight { get; set; }

  /// <summary>
  ///   Underline.
  /// </summary>
  public Underline? Underline { get; set; }

  /// <summary>
  ///   TextEffect.
  /// </summary>
  public TextEffectKind? TextEffect { get; set; }

  /// <summary>
  ///   Border.
  /// </summary>
  public BorderType? Border { get; set; }

  /// <summary>
  ///   Shading.
  /// </summary>
  public Shading? Shading { get; set; }

  /// <summary>
  ///   FitText.
  /// </summary>
  public FitText? FitText { get; set; }

  /// <summary>
  ///   VerticalTextAlignment.
  /// </summary>
  public VerticalPositionKind? VerticalTextAlignment { get; set; }

  /// <summary>
  ///   RightToLeftText.
  /// </summary>
  public Boolean? RightToLeftText { get; set; }

  /// <summary>
  ///   ComplexScript.
  /// </summary>
  public Boolean? ComplexScript { get; set; }

  /// <summary>
  ///   Emphasis.
  /// </summary>
  public EmphasisMarkKind? Emphasis { get; set; }

  /// <summary>
  ///   Languages.
  /// </summary>
  public Languages? Language { get; set; }

  /// <summary>
  ///   EastAsianLayout.
  /// </summary>
  public EastAsianLayout? EastAsianLayout { get; set; }

  /// <summary>
  ///   SpecVanish.
  /// </summary>
  public Boolean? SpecVanish { get; set; }

  /// <summary>
  ///   Glow, this property is only available in Office 2010 and later..
  /// </summary>
  public Glow? Glow { get; set; }

  /// <summary>
  ///   Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  public Shadow2? Shadow14 { get; set; }

  /// <summary>
  ///   Reflection, this property is only available in Office 2010 and later..
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
  ///   Ligatures, this property is only available in Office 2010 and later..
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

  /// <summary>
  ///   ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  public OnOffKind? ContextualAlternatives { get; set; }

  /// <summary>
  ///   RunPropertiesChange.
  /// </summary>
  public RunPropertiesChange? RunPropertiesChange { get; set; }
}