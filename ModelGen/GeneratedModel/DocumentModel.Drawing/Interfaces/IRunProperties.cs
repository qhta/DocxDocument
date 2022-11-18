namespace DocumentModel.Drawing;

/// <summary>
/// Text Run Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRightToLeft))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHighlight))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectDag))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHyperlinkOnClick))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHyperlinkOnMouseOver))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IOutline))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IUnderline))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPatternFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISolidFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILatinFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEastAsianFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IComplexScriptFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISymbolFont))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IUnderlineFillText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IUnderlineFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IUnderlineFollowsText))]
public interface IRunProperties // : DocumentFormat.OpenXml.Drawing.TextCharacterPropertiesType
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  [Obsolete("Please use the property 'SmartTagClean' as this property will be removed in a future version")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public bool? SmtClean { get ; set; }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  [Obsolete("Please use the property 'SmartTagId' as this property will be removed in a future version")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public uint? SmtId { get ; set; }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  public bool? Kumimoji { get ; set; }
  
  /// <summary>
  /// lang
  /// </summary>
  public string? Language { get ; set; }
  
  /// <summary>
  /// altLang
  /// </summary>
  public string? AlternativeLanguage { get ; set; }
  
  /// <summary>
  /// sz
  /// </summary>
  public int? FontSize { get ; set; }
  
  /// <summary>
  /// b
  /// </summary>
  public bool? Bold { get ; set; }
  
  /// <summary>
  /// i
  /// </summary>
  public bool? Italic { get ; set; }
  
  /// <summary>
  /// u
  /// </summary>
  public TextUnderline? Underline { get ; set; }
  
  /// <summary>
  /// strike
  /// </summary>
  public TextStrike? Strike { get ; set; }
  
  /// <summary>
  /// kern
  /// </summary>
  public int? Kerning { get ; set; }
  
  /// <summary>
  /// cap
  /// </summary>
  public TextCaps? Capital { get ; set; }
  
  /// <summary>
  /// spc
  /// </summary>
  public int? Spacing { get ; set; }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  public bool? NormalizeHeight { get ; set; }
  
  /// <summary>
  /// baseline
  /// </summary>
  public int? Baseline { get ; set; }
  
  /// <summary>
  /// noProof
  /// </summary>
  public bool? NoProof { get ; set; }
  
  /// <summary>
  /// dirty
  /// </summary>
  public bool? Dirty { get ; set; }
  
  /// <summary>
  /// err
  /// </summary>
  public bool? SpellingError { get ; set; }
  
  /// <summary>
  /// smtClean
  /// </summary>
  public bool? SmartTagClean { get ; set; }
  
  /// <summary>
  /// smtId
  /// </summary>
  public uint? SmartTagId { get ; set; }
  
  /// <summary>
  /// bmk
  /// </summary>
  public string? Bookmark { get ; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawing.IOutline? Outline { get ; set; }
  
}
