namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public class TextCharacterPropertiesType2Impl: ModelElementImpl, TextCharacterPropertiesType2
{
  public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public Boolean? SmtClean
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public UInt32? SmtId
  {
    get;
    set;
  }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  public Boolean? Kumimoji
  {
    get;
    set;
  }
  
  /// <summary>
  /// lang
  /// </summary>
  public String? Language
  {
    get;
    set;
  }
  
  /// <summary>
  /// altLang
  /// </summary>
  public String? AlternativeLanguage
  {
    get;
    set;
  }
  
  /// <summary>
  /// sz
  /// </summary>
  public Int32? FontSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// b
  /// </summary>
  public Boolean? Bold
  {
    get;
    set;
  }
  
  /// <summary>
  /// i
  /// </summary>
  public Boolean? Italic
  {
    get;
    set;
  }
  
  /// <summary>
  /// u
  /// </summary>
  public TextUnderlineKind? Underline
  {
    get => (TextUnderlineKind?)OpenXmlElement?.Underline?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Underline = (DocumentFormat.OpenXml.Drawing.TextUnderlineValues?)value;
    }
  }
  
  /// <summary>
  /// strike
  /// </summary>
  public TextStrikeKind? Strike
  {
    get => (TextStrikeKind?)OpenXmlElement?.Strike?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Strike = (DocumentFormat.OpenXml.Drawing.TextStrikeValues?)value;
    }
  }
  
  /// <summary>
  /// kern
  /// </summary>
  public Int32? Kerning
  {
    get;
    set;
  }
  
  /// <summary>
  /// cap
  /// </summary>
  public TextCapsKind? Capital
  {
    get => (TextCapsKind?)OpenXmlElement?.Capital?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Capital = (DocumentFormat.OpenXml.Drawing.TextCapsValues?)value;
    }
  }
  
  /// <summary>
  /// spc
  /// </summary>
  public Int32? Spacing
  {
    get;
    set;
  }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  public Boolean? NormalizeHeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// baseline
  /// </summary>
  public Int32? Baseline
  {
    get;
    set;
  }
  
  /// <summary>
  /// noProof
  /// </summary>
  public Boolean? NoProof
  {
    get;
    set;
  }
  
  /// <summary>
  /// dirty
  /// </summary>
  public Boolean? Dirty
  {
    get;
    set;
  }
  
  /// <summary>
  /// err
  /// </summary>
  public Boolean? SpellingError
  {
    get;
    set;
  }
  
  /// <summary>
  /// smtClean
  /// </summary>
  public Boolean? SmartTagClean
  {
    get;
    set;
  }
  
  /// <summary>
  /// smtId
  /// </summary>
  public UInt32? SmartTagId
  {
    get;
    set;
  }
  
  /// <summary>
  /// bmk
  /// </summary>
  public String? Bookmark
  {
    get;
    set;
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public Outline? Outline
  {
    get;
    set;
  }
  
  public Boolean? NoFill
  {
    get;
    set;
  }
  
  public SolidFill? SolidFill
  {
    get;
    set;
  }
  
  public GradientFill? GradientFill
  {
    get;
    set;
  }
  
  public BlipFill2? BlipFill
  {
    get;
    set;
  }
  
  public PatternFill? PatternFill
  {
    get;
    set;
  }
  
  public Boolean? GroupFill
  {
    get;
    set;
  }
  
  public EffectList? EffectList
  {
    get;
    set;
  }
  
  public EffectDag? EffectDag
  {
    get;
    set;
  }
  
  public Highlight? Highlight
  {
    get;
    set;
  }
  
  public Boolean? UnderlineFollowsText
  {
    get;
    set;
  }
  
  public Boolean? UnderlineFillText
  {
    get;
    set;
  }
  
  public UnderlineFill? UnderlineFill
  {
    get;
    set;
  }
  
  public TextFontType? LatinFont
  {
    get;
    set;
  }
  
  public TextFontType? EastAsianFont
  {
    get;
    set;
  }
  
  public TextFontType? ComplexScriptFont
  {
    get;
    set;
  }
  
  public TextFontType? SymbolFont
  {
    get;
    set;
  }
  
  public HyperlinkOnClick? HyperlinkOnClick
  {
    get;
    set;
  }
  
  public HyperlinkOnMouseOver? HyperlinkOnMouseOver
  {
    get;
    set;
  }
  
  public Boolean? RightToLeft
  {
    get;
    set;
  }
  
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
