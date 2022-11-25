namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public interface ITextCharacterPropertiesType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public System.Boolean? SmtClean { get ; set; }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public System.UInt32? SmtId { get ; set; }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  public System.Boolean? Kumimoji { get ; set; }
  
  /// <summary>
  /// lang
  /// </summary>
  public System.String? Language { get ; set; }
  
  /// <summary>
  /// altLang
  /// </summary>
  public System.String? AlternativeLanguage { get ; set; }
  
  /// <summary>
  /// sz
  /// </summary>
  public System.Int32? FontSize { get ; set; }
  
  /// <summary>
  /// b
  /// </summary>
  public System.Boolean? Bold { get ; set; }
  
  /// <summary>
  /// i
  /// </summary>
  public System.Boolean? Italic { get ; set; }
  
  /// <summary>
  /// u
  /// </summary>
  public DocumentModel.Drawing.TextUnderlineKind? Underline { get ; set; }
  
  /// <summary>
  /// strike
  /// </summary>
  public DocumentModel.Drawing.TextStrikeKind? Strike { get ; set; }
  
  /// <summary>
  /// kern
  /// </summary>
  public System.Int32? Kerning { get ; set; }
  
  /// <summary>
  /// cap
  /// </summary>
  public DocumentModel.Drawing.TextCapsKind? Capital { get ; set; }
  
  /// <summary>
  /// spc
  /// </summary>
  public System.Int32? Spacing { get ; set; }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  public System.Boolean? NormalizeHeight { get ; set; }
  
  /// <summary>
  /// baseline
  /// </summary>
  public System.Int32? Baseline { get ; set; }
  
  /// <summary>
  /// noProof
  /// </summary>
  public System.Boolean? NoProof { get ; set; }
  
  /// <summary>
  /// dirty
  /// </summary>
  public System.Boolean? Dirty { get ; set; }
  
  /// <summary>
  /// err
  /// </summary>
  public System.Boolean? SpellingError { get ; set; }
  
  /// <summary>
  /// smtClean
  /// </summary>
  public System.Boolean? SmartTagClean { get ; set; }
  
  /// <summary>
  /// smtId
  /// </summary>
  public System.UInt32? SmartTagId { get ; set; }
  
  /// <summary>
  /// bmk
  /// </summary>
  public System.String? Bookmark { get ; set; }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawing.ILinePropertiesType? Outline { get ; set; }
  
}
