namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Definition.
/// </summary>
public partial class Level
{
  /// <summary>
  /// Numbering Level
  /// </summary>
  public Int32? LevelIndex { get; set; }
  
  /// <summary>
  /// Template Code
  /// </summary>
  public DocumentModel.HexBinary? TemplateCode { get; set; }
  
  /// <summary>
  /// Tentative Numbering
  /// </summary>
  public Boolean? Tentative { get; set; }
  
  /// <summary>
  /// Starting Value.
  /// </summary>
  public Int32? StartNumberingValue { get; set; }
  
  /// <summary>
  /// Numbering Format.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingFormat? NumberingFormat { get; set; }
  
  /// <summary>
  /// Restart Numbering Level Symbol.
  /// </summary>
  public Int32? LevelRestart { get; set; }
  
  /// <summary>
  /// Paragraph Style's Associated Numbering Level.
  /// </summary>
  public String? ParagraphStyleIdInLevel { get; set; }
  
  /// <summary>
  /// Display All Levels Using Arabic Numerals.
  /// </summary>
  public Boolean? IsLegalNumberingStyle { get; set; }
  
  /// <summary>
  /// Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  public DocumentModel.Wordprocessing.LevelSuffixKind? LevelSuffix { get; set; }
  
  /// <summary>
  /// Numbering Level Text.
  /// </summary>
  public DocumentModel.Wordprocessing.LevelText? LevelText { get; set; }
  
  /// <summary>
  /// Picture Numbering Symbol Definition Reference.
  /// </summary>
  public Int32? LevelPictureBulletId { get; set; }
  
  /// <summary>
  /// Legacy Numbering Level Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.LegacyNumbering? LegacyNumbering { get; set; }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public DocumentModel.Wordprocessing.LevelJustificationKind? LevelJustification { get; set; }
  
  /// <summary>
  /// Numbering Level Associated Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.PreviousParagraphProperties? PreviousParagraphProperties { get; set; }
  
  /// <summary>
  /// Numbering Symbol Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingSymbolRunProperties? NumberingSymbolRunProperties { get; set; }
  
}
