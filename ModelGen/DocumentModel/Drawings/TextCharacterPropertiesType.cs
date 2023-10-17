namespace DocumentModel.Drawings;


/// <summary>
///   Defines the TextCharacterPropertiesType Class.
/// </summary>
public partial class TextCharacterPropertiesType
{
  public Boolean? SmtClean { get; set; }
  
  public UInt32? SmtId { get; set; }
  
  
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
  public DocumentModel.Drawings.TextUnderlineKind? Underline { get; set; }
  
  
  /// <summary>
  ///   strike
  /// </summary>
  public DocumentModel.Drawings.TextStrikeKind? Strike { get; set; }
  
  
  /// <summary>
  ///   kern
  /// </summary>
  public Int32? Kerning { get; set; }
  
  
  /// <summary>
  ///   cap
  /// </summary>
  public DocumentModel.Drawings.TextCapsKind? Capital { get; set; }
  
  
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
  public UInt32? SmartTagId { get; set; }
  
  
  /// <summary>
  ///   bmk
  /// </summary>
  public String? Bookmark { get; set; }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  public DocumentModel.Drawings.Outline? Outline { get; set; }
  
}
