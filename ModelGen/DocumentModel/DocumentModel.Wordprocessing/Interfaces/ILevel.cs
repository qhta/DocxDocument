namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Definition.
/// </summary>
public interface ILevel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Numbering Level
  /// </summary>
  public Int32? LevelIndex { get ; set; }
  
  /// <summary>
  /// Template Code
  /// </summary>
  public IHexBinaryValue? TemplateCode { get ; set; }
  
  /// <summary>
  /// Tentative Numbering
  /// </summary>
  public Boolean? Tentative { get ; set; }
  
  /// <summary>
  /// Starting Value.
  /// </summary>
  public IStartNumberingValue? StartNumberingValue { get ; set; }
  
  /// <summary>
  /// Numbering Format.
  /// </summary>
  public INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Restart Numbering Level Symbol.
  /// </summary>
  public ILevelRestart? LevelRestart { get ; set; }
  
  /// <summary>
  /// Paragraph Style's Associated Numbering Level.
  /// </summary>
  public IParagraphStyleIdInLevel? ParagraphStyleIdInLevel { get ; set; }
  
  /// <summary>
  /// Display All Levels Using Arabic Numerals.
  /// </summary>
  public IsLegalNumberingStyle? IsLegalNumberingStyle { get ; set; }
  
  /// <summary>
  /// Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues>? LevelSuffix { get ; set; }
  
  /// <summary>
  /// Numbering Level Text.
  /// </summary>
  public ILevelText? LevelText { get ; set; }
  
  /// <summary>
  /// Picture Numbering Symbol Definition Reference.
  /// </summary>
  public ILevelPictureBulletId? LevelPictureBulletId { get ; set; }
  
  /// <summary>
  /// Legacy Numbering Level Properties.
  /// </summary>
  public ILegacyNumbering? LegacyNumbering { get ; set; }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues>? LevelJustification { get ; set; }
  
  /// <summary>
  /// Numbering Level Associated Paragraph Properties.
  /// </summary>
  public IPreviousParagraphProperties? PreviousParagraphProperties { get ; set; }
  
  /// <summary>
  /// Numbering Symbol Run Properties.
  /// </summary>
  public INumberingSymbolRunProperties? NumberingSymbolRunProperties { get ; set; }
  
}
