namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
public interface IRunProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RunStyle.
  /// </summary>
  public System.String? RunStyle { get ; set; }
  
  /// <summary>
  /// RunFonts.
  /// </summary>
  public DocumentModel.Wordprocessing.IRunFonts? RunFonts { get ; set; }
  
  /// <summary>
  /// Bold.
  /// </summary>
  public System.Boolean? Bold { get ; set; }
  
  /// <summary>
  /// BoldComplexScript.
  /// </summary>
  public System.Boolean? BoldComplexScript { get ; set; }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public System.Boolean? Italic { get ; set; }
  
  /// <summary>
  /// ItalicComplexScript.
  /// </summary>
  public System.Boolean? ItalicComplexScript { get ; set; }
  
  /// <summary>
  /// Caps.
  /// </summary>
  public System.Boolean? Caps { get ; set; }
  
  /// <summary>
  /// SmallCaps.
  /// </summary>
  public System.Boolean? SmallCaps { get ; set; }
  
  /// <summary>
  /// Strike.
  /// </summary>
  public System.Boolean? Strike { get ; set; }
  
  /// <summary>
  /// DoubleStrike.
  /// </summary>
  public System.Boolean? DoubleStrike { get ; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public System.Boolean? Outline { get ; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public System.Boolean? Shadow { get ; set; }
  
  /// <summary>
  /// Emboss.
  /// </summary>
  public System.Boolean? Emboss { get ; set; }
  
  /// <summary>
  /// Imprint.
  /// </summary>
  public System.Boolean? Imprint { get ; set; }
  
  /// <summary>
  /// NoProof.
  /// </summary>
  public System.Boolean? NoProof { get ; set; }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public System.Boolean? SnapToGrid { get ; set; }
  
  /// <summary>
  /// Vanish.
  /// </summary>
  public System.Boolean? Vanish { get ; set; }
  
  /// <summary>
  /// WebHidden.
  /// </summary>
  public System.Boolean? WebHidden { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public DocumentModel.Wordprocessing.IColor? Color { get ; set; }
  
  /// <summary>
  /// Spacing.
  /// </summary>
  public System.Int32? Spacing { get ; set; }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  public System.Int32? CharacterScale { get ; set; }
  
  /// <summary>
  /// Kern.
  /// </summary>
  public System.UInt32? Kern { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public System.String? Position { get ; set; }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  public System.String? FontSize { get ; set; }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  public System.String? FontSizeComplexScript { get ; set; }
  
  /// <summary>
  /// Highlight.
  /// </summary>
  public DocumentModel.Wordprocessing.HighlightColorKind? Highlight { get ; set; }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public DocumentModel.Wordprocessing.IUnderline? Underline { get ; set; }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  public DocumentModel.Wordprocessing.TextEffectKind? TextEffect { get ; set; }
  
  /// <summary>
  /// Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? Border { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.IShading? Shading { get ; set; }
  
  /// <summary>
  /// FitText.
  /// </summary>
  public DocumentModel.Wordprocessing.IFitText? FitText { get ; set; }
  
  /// <summary>
  /// VerticalTextAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalPositionKind? VerticalTextAlignment { get ; set; }
  
  /// <summary>
  /// RightToLeftText.
  /// </summary>
  public System.Boolean? RightToLeftText { get ; set; }
  
  /// <summary>
  /// ComplexScript.
  /// </summary>
  public System.Boolean? ComplexScript { get ; set; }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  public DocumentModel.Wordprocessing.EmphasisMarkKind? Emphasis { get ; set; }
  
  /// <summary>
  /// Languages.
  /// </summary>
  public DocumentModel.Wordprocessing.ILanguageType? Languages { get ; set; }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  public DocumentModel.Wordprocessing.IEastAsianLayout? EastAsianLayout { get ; set; }
  
  /// <summary>
  /// SpecVanish.
  /// </summary>
  public System.Boolean? SpecVanish { get ; set; }
  
  /// <summary>
  /// Glow, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.IGlow? Glow { get ; set; }
  
  /// <summary>
  /// Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.IShadow? Shadow14 { get ; set; }
  
  /// <summary>
  /// Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.IReflection? Reflection { get ; set; }
  
  /// <summary>
  /// TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.ITextOutlineEffect? TextOutlineEffect { get ; set; }
  
  /// <summary>
  /// FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.IFillTextEffect? FillTextEffect { get ; set; }
  
  /// <summary>
  /// Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.IScene3D? Scene3D { get ; set; }
  
  /// <summary>
  /// Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.IProperties3D? Properties3D { get ; set; }
  
  /// <summary>
  /// Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.LigaturesKind? Ligatures { get ; set; }
  
  /// <summary>
  /// NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.NumberFormKind? NumberingFormat { get ; set; }
  
  /// <summary>
  /// NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.NumberSpacingKind? NumberSpacing { get ; set; }
  
  /// <summary>
  /// StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.IStylisticSets? StylisticSets { get ; set; }
  
  /// <summary>
  /// ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.OnOffKind? ContextualAlternatives { get ; set; }
  
  /// <summary>
  /// RunPropertiesChange.
  /// </summary>
  public DocumentModel.Wordprocessing.IRunPropertiesChange? RunPropertiesChange { get ; set; }
  
}
