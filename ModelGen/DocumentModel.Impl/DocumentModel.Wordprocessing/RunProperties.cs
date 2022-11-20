namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IColor))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEastAsianLayout))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEmphasis))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFitText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunFonts))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IHighlight))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IKern))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFontSize))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFontSizeComplexScript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILanguages))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBold))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBoldComplexScript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IItalic))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IItalicComplexScript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICaps))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISmallCaps))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStrike))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDoubleStrike))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IOutline))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShadow))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEmboss))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IImprint))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INoProof))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISnapToGrid))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IVanish))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IWebHidden))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRightToLeftText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IComplexScript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISpecVanish))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunPropertiesChange))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShading))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISpacing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPosition))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunStyle))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextEffect))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICharacterScale))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IUnderline))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IVerticalTextAlignment))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IFillTextEffect))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IGlow))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ILigatures))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.INumberingFormat))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.INumberSpacing))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IContextualAlternatives))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IProperties3D))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IReflection))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IScene3D))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IShadow))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IStylisticSets))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ITextOutlineEffect))]
public class RunProperties: IRunProperties
{
  /// <summary>
  /// RunStyle.
  /// </summary>
  public IRunStyle? RunStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// RunFonts.
  /// </summary>
  public IRunFonts? RunFonts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bold.
  /// </summary>
  public DocumentModel.Wordprocessing.IBold? Bold
  {
    get;
    set;
  }
  
  /// <summary>
  /// BoldComplexScript.
  /// </summary>
  public IBoldComplexScript? BoldComplexScript
  {
    get;
    set;
  }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public DocumentModel.Wordprocessing.IItalic? Italic
  {
    get;
    set;
  }
  
  /// <summary>
  /// ItalicComplexScript.
  /// </summary>
  public IItalicComplexScript? ItalicComplexScript
  {
    get;
    set;
  }
  
  /// <summary>
  /// Caps.
  /// </summary>
  public ICaps? Caps
  {
    get;
    set;
  }
  
  /// <summary>
  /// SmallCaps.
  /// </summary>
  public ISmallCaps? SmallCaps
  {
    get;
    set;
  }
  
  /// <summary>
  /// Strike.
  /// </summary>
  public DocumentModel.Wordprocessing.IStrike? Strike
  {
    get;
    set;
  }
  
  /// <summary>
  /// DoubleStrike.
  /// </summary>
  public IDoubleStrike? DoubleStrike
  {
    get;
    set;
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Wordprocessing.IOutline? Outline
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public DocumentModel.Wordprocessing.IShadow? Shadow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Emboss.
  /// </summary>
  public IEmboss? Emboss
  {
    get;
    set;
  }
  
  /// <summary>
  /// Imprint.
  /// </summary>
  public IImprint? Imprint
  {
    get;
    set;
  }
  
  /// <summary>
  /// NoProof.
  /// </summary>
  public INoProof? NoProof
  {
    get;
    set;
  }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public ISnapToGrid? SnapToGrid
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vanish.
  /// </summary>
  public IVanish? Vanish
  {
    get;
    set;
  }
  
  /// <summary>
  /// WebHidden.
  /// </summary>
  public IWebHidden? WebHidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Color.
  /// </summary>
  public DocumentModel.Wordprocessing.IColor? Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Spacing.
  /// </summary>
  public ISpacing? Spacing
  {
    get;
    set;
  }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  public ICharacterScale? CharacterScale
  {
    get;
    set;
  }
  
  /// <summary>
  /// Kern.
  /// </summary>
  public IKern? Kern
  {
    get;
    set;
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Wordprocessing.IPosition? Position
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  public DocumentModel.Wordprocessing.IFontSize? FontSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  public IFontSizeComplexScript? FontSizeComplexScript
  {
    get;
    set;
  }
  
  /// <summary>
  /// Highlight.
  /// </summary>
  public DocumentModel.Wordprocessing.IHighlight? Highlight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public DocumentModel.Wordprocessing.IUnderline? Underline
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  public ITextEffect? TextEffect
  {
    get;
    set;
  }
  
  /// <summary>
  /// Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorder? Border
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading
  {
    get;
    set;
  }
  
  /// <summary>
  /// FitText.
  /// </summary>
  public IFitText? FitText
  {
    get;
    set;
  }
  
  /// <summary>
  /// VerticalTextAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.IVerticalTextAlignment? VerticalTextAlignment
  {
    get;
    set;
  }
  
  /// <summary>
  /// RightToLeftText.
  /// </summary>
  public IRightToLeftText? RightToLeftText
  {
    get;
    set;
  }
  
  /// <summary>
  /// ComplexScript.
  /// </summary>
  public IComplexScript? ComplexScript
  {
    get;
    set;
  }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  public IEmphasis? Emphasis
  {
    get;
    set;
  }
  
  /// <summary>
  /// Languages.
  /// </summary>
  public ILanguages? Languages
  {
    get;
    set;
  }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  public IEastAsianLayout? EastAsianLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// SpecVanish.
  /// </summary>
  public ISpecVanish? SpecVanish
  {
    get;
    set;
  }
  
  /// <summary>
  /// Glow, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.IGlow? Glow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.IShadow? Shadow14
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.IReflection? Reflection
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public ITextOutlineEffect? TextOutlineEffect
  {
    get;
    set;
  }
  
  /// <summary>
  /// FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  public IFillTextEffect? FillTextEffect
  {
    get;
    set;
  }
  
  /// <summary>
  /// Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.IScene3D? Scene3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  public IProperties3D? Properties3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  public ILigatures? Ligatures
  {
    get;
    set;
  }
  
  /// <summary>
  /// NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Office2010.Word.INumberingFormat? NumberingFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  public INumberSpacing? NumberSpacing
  {
    get;
    set;
  }
  
  /// <summary>
  /// StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  public IStylisticSets? StylisticSets
  {
    get;
    set;
  }
  
  /// <summary>
  /// ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  public IContextualAlternatives? ContextualAlternatives
  {
    get;
    set;
  }
  
  /// <summary>
  /// RunPropertiesChange.
  /// </summary>
  public IRunPropertiesChange? RunPropertiesChange
  {
    get;
    set;
  }
  
}
