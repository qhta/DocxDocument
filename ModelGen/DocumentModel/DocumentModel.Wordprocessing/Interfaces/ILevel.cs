namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Definition.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILevelRestart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILevelPictureBulletId))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILevelJustification))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILevelSuffix))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILevelText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILegacyNumbering))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStartNumberingValue))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingFormat))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IIsLegalNumberingStyle))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPreviousParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingSymbolRunProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IParagraphStyleIdInLevel))]
public interface ILevel // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Numbering Level
  /// </summary>
  public int? LevelIndex { get ; set; }
  
  /// <summary>
  /// Template Code
  /// </summary>
  public IHexBinaryValue? TemplateCode { get ; set; }
  
  /// <summary>
  /// Tentative Numbering
  /// </summary>
  public bool? Tentative { get ; set; }
  
  /// <summary>
  /// Starting Value.
  /// </summary>
  public IStartNumberingValue? StartNumberingValue { get ; set; }
  
  /// <summary>
  /// Numbering Format.
  /// </summary>
  public DocumentModel.Wordprocessing.INumberingFormat? NumberingFormat { get ; set; }
  
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
  public IIsLegalNumberingStyle? IsLegalNumberingStyle { get ; set; }
  
  /// <summary>
  /// Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  public ILevelSuffix? LevelSuffix { get ; set; }
  
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
  public ILevelJustification? LevelJustification { get ; set; }
  
  /// <summary>
  /// Numbering Level Associated Paragraph Properties.
  /// </summary>
  public IPreviousParagraphProperties? PreviousParagraphProperties { get ; set; }
  
  /// <summary>
  /// Numbering Symbol Run Properties.
  /// </summary>
  public INumberingSymbolRunProperties? NumberingSymbolRunProperties { get ; set; }
  
}
