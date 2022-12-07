namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
public interface RunProperties
{
  /// <summary>
  /// RunFonts.
  /// </summary>
  public RunFonts? RunFonts { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public Color? Color { get ; set; }
  
  /// <summary>
  /// Highlight.
  /// </summary>
  public HighlightColorKind? Highlight { get ; set; }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public Underline? Underline { get ; set; }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  public TextEffectKind? TextEffect { get ; set; }
  
  /// <summary>
  /// Border.
  /// </summary>
  public BorderType? Border { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public Shading? Shading { get ; set; }
  
  /// <summary>
  /// FitText.
  /// </summary>
  public FitText? FitText { get ; set; }
  
  /// <summary>
  /// VerticalTextAlignment.
  /// </summary>
  public VerticalPositionKind? VerticalTextAlignment { get ; set; }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  public EmphasisMarkKind? Emphasis { get ; set; }
  
  /// <summary>
  /// Languages.
  /// </summary>
  public Boolean? Languages { get ; set; }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  public EastAsianLayout? EastAsianLayout { get ; set; }
  
  /// <summary>
  /// Glow, this property is only available in Office 2010 and later..
  /// </summary>
  public Glow? Glow { get ; set; }
  
  /// <summary>
  /// Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  public Shadow? Shadow14 { get ; set; }
  
  /// <summary>
  /// Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  public Reflection? Reflection { get ; set; }
  
  /// <summary>
  /// TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public TextOutlineEffect? TextOutlineEffect { get ; set; }
  
  /// <summary>
  /// FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public FillTextEffect? FillTextEffect { get ; set; }
  
  /// <summary>
  /// Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  public Scene3D? Scene3D { get ; set; }
  
  /// <summary>
  /// Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  public Properties3D? Properties3D { get ; set; }
  
  /// <summary>
  /// Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  public LigaturesKind? Ligatures { get ; set; }
  
  /// <summary>
  /// NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  public NumberFormKind? NumberingFormat { get ; set; }
  
  /// <summary>
  /// NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  public NumberSpacingKind? NumberSpacing { get ; set; }
  
  /// <summary>
  /// StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  public StylisticSets? StylisticSets { get ; set; }
  
  /// <summary>
  /// ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  public OnOffKind? ContextualAlternatives { get ; set; }
  
  /// <summary>
  /// RunPropertiesChange.
  /// </summary>
  public RunPropertiesChange? RunPropertiesChange { get ; set; }
  
}
