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
  public UInt32? SmtId { get; set; }
  
  
  /// <summary>
  ///   kumimoji
  /// </summary>
  [SchemaAttr("kumimoji")]
  public Boolean? Kumimoji { get; set; }
  
  
  /// <summary>
  ///   lang
  /// </summary>
  [SchemaAttr("lang")]
  public String? Language { get; set; }
  
  
  /// <summary>
  ///   altLang
  /// </summary>
  [SchemaAttr("altLang")]
  public String? AlternativeLanguage { get; set; }
  
  
  /// <summary>
  ///   sz
  /// </summary>
  [SchemaAttr("sz")]
  public Int32? FontSize { get; set; }
  
  
  /// <summary>
  ///   b
  /// </summary>
  [SchemaAttr("b")]
  public Boolean? Bold { get; set; }
  
  
  /// <summary>
  ///   i
  /// </summary>
  [SchemaAttr("i")]
  public Boolean? Italic { get; set; }
  
  
  /// <summary>
  ///   u
  /// </summary>
  [SchemaAttr("u")]
  public DocumentModel.Drawings.TextUnderlineValues? Underline { get; set; }
  
  
  /// <summary>
  ///   strike
  /// </summary>
  [SchemaAttr("strike")]
  public DocumentModel.Drawings.TextStrikeValues? Strike { get; set; }
  
  
  /// <summary>
  ///   kern
  /// </summary>
  [SchemaAttr("kern")]
  public Int32? Kerning { get; set; }
  
  
  /// <summary>
  ///   cap
  /// </summary>
  [SchemaAttr("cap")]
  public DocumentModel.Drawings.TextCapsValues? Capital { get; set; }
  
  
  /// <summary>
  ///   spc
  /// </summary>
  [SchemaAttr("spc")]
  public Int32? Spacing { get; set; }
  
  
  /// <summary>
  ///   normalizeH
  /// </summary>
  [SchemaAttr("normalizeH")]
  public Boolean? NormalizeHeight { get; set; }
  
  
  /// <summary>
  ///   baseline
  /// </summary>
  [SchemaAttr("baseline")]
  public Int32? Baseline { get; set; }
  
  
  /// <summary>
  ///   noProof
  /// </summary>
  [SchemaAttr("noProof")]
  public Boolean? NoProof { get; set; }
  
  
  /// <summary>
  ///   dirty
  /// </summary>
  [SchemaAttr("dirty")]
  public Boolean? Dirty { get; set; }
  
  
  /// <summary>
  ///   err
  /// </summary>
  [SchemaAttr("err")]
  public Boolean? SpellingError { get; set; }
  
  
  /// <summary>
  ///   smtClean
  /// </summary>
  [SchemaAttr("smtClean")]
  public Boolean? SmartTagClean { get; set; }
  
  
  /// <summary>
  ///   smtId
  /// </summary>
  [SchemaAttr("smtId")]
  public UInt32? SmartTagId { get; set; }
  
  
  /// <summary>
  ///   bmk
  /// </summary>
  [SchemaAttr("bmk")]
  public String? Bookmark { get; set; }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  public DocumentModel.Drawings.Outline? Outline { get; set; }
  
}
