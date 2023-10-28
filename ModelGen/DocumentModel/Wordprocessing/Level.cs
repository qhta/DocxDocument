namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Level Definition.
/// </summary>
public partial class Level
{
  
  /// <summary>
  ///   Numbering Level
  /// </summary>
  public Int32? LevelIndex { get; set; }
  
  
  /// <summary>
  ///   Template Code
  /// </summary>
  public DM.HexBinary? TemplateCode { get; set; }
  
  
  /// <summary>
  ///   Tentative Numbering
  /// </summary>
  public Boolean? Tentative { get; set; }
  
  
  /// <summary>
  ///   Starting Value.
  /// </summary>
  public DMW.StartNumberingValue? StartNumberingValue { get; set; }
  
  
  /// <summary>
  ///   Numbering Format.
  /// </summary>
  public DMW.NumberingFormat? NumberingFormat { get; set; }
  
  
  /// <summary>
  ///   Restart Numbering Level Symbol.
  /// </summary>
  public DMW.LevelRestart? LevelRestart { get; set; }
  
  
  /// <summary>
  ///   Paragraph Style's Associated Numbering Level.
  /// </summary>
  public DMW.ParagraphStyleIdInLevel? ParagraphStyleIdInLevel { get; set; }
  
  
  /// <summary>
  ///   Display All Levels Using Arabic Numerals.
  /// </summary>
  public DMW.IsLegalNumberingStyle? IsLegalNumberingStyle { get; set; }
  
  
  /// <summary>
  ///   Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  public DMW.LevelSuffixKind? LevelSuffix { get; set; }
  
  
  /// <summary>
  ///   Numbering Level Text.
  /// </summary>
  public DMW.LevelText? LevelText { get; set; }
  
  
  /// <summary>
  ///   Picture Numbering Symbol Definition Reference.
  /// </summary>
  public DMW.LevelPictureBulletId? LevelPictureBulletId { get; set; }
  
  
  /// <summary>
  ///   Legacy Numbering Level Properties.
  /// </summary>
  public DMW.LegacyNumbering? LegacyNumbering { get; set; }
  
  
  /// <summary>
  ///   Justification.
  /// </summary>
  public DMW.LevelJustificationKind? LevelJustification { get; set; }
  
  
  /// <summary>
  ///   Numbering Level Associated Paragraph Properties.
  /// </summary>
  public DMW.PreviousParagraphProperties? PreviousParagraphProperties { get; set; }
  
  
  /// <summary>
  ///   Numbering Symbol Run Properties.
  /// </summary>
  public DMW.NumberingSymbolRunProperties? NumberingSymbolRunProperties { get; set; }
  
}
