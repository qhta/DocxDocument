namespace DocumentModel.Drawings;


/// <summary>
///   Defines the TextCharacterPropertiesType Class.
/// </summary>
public partial class TextCharacterPropertiesType
{
  [Obsolete("Please use the property 'SmartTagClean' as this property will be removed in a future version")]
  [EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
  public Boolean? SmtClean { get; set; }
  
  [Obsolete("Please use the property 'SmartTagId' as this property will be removed in a future version")]
  [EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
  public HexInt? SmtId { get; set; }
  
  
  /// <summary>
  ///   kumimoji
  /// </summary>
  public Boolean? Kumimoji { get; set; }
  
  
  /// <summary>
  ///   lang
  /// </summary>
  public String? Language { get; set; }
  
  
  /// <summary>
  ///   altLang
  /// </summary>
  public String? AlternativeLanguage { get; set; }
  
  
  /// <summary>
  ///   sz
  /// </summary>
  public Int32? FontSize { get; set; }
  
  
  /// <summary>
  ///   b
  /// </summary>
  public Boolean? Bold { get; set; }
  
  
  /// <summary>
  ///   i
  /// </summary>
  public Boolean? Italic { get; set; }
  
  
  /// <summary>
  ///   u
  /// </summary>
  public TextUnderlineKind? Underline { get; set; }
  
  
  /// <summary>
  ///   strike
  /// </summary>
  public TextStrikeKind? Strike { get; set; }
  
  
  /// <summary>
  ///   kern
  /// </summary>
  public Int32? Kerning { get; set; }
  
  
  /// <summary>
  ///   cap
  /// </summary>
  public TextCapsKind? Capital { get; set; }
  
  
  /// <summary>
  ///   spc
  /// </summary>
  public Int32? Spacing { get; set; }
  
  
  /// <summary>
  ///   normalizeH
  /// </summary>
  public Boolean? NormalizeHeight { get; set; }
  
  
  /// <summary>
  ///   baseline
  /// </summary>
  public Int32? Baseline { get; set; }
  
  
  /// <summary>
  ///   noProof
  /// </summary>
  public Boolean? NoProof { get; set; }
  
  
  /// <summary>
  ///   dirty
  /// </summary>
  public Boolean? Dirty { get; set; }
  
  
  /// <summary>
  ///   err
  /// </summary>
  public Boolean? SpellingError { get; set; }
  
  
  /// <summary>
  ///   smtClean
  /// </summary>
  public Boolean? SmartTagClean { get; set; }
  
  
  /// <summary>
  ///   smtId
  /// </summary>
  public HexInt? SmartTagId { get; set; }
  
  
  /// <summary>
  ///   bmk
  /// </summary>
  public String? Bookmark { get; set; }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  public Outline? Outline { get; set; }
  
}
