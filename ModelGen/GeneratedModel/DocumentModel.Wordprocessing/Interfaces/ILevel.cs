namespace DocumentModel.Wordprocessing;

public interface ILevel // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? LevelIndex { get ; set; }

  public IHexBinaryValue? TemplateCode { get ; set; }

  public bool? Tentative { get ; set; }

  public IStartNumberingValue? StartNumberingValue { get ; set; }

  public DocumentModel.Wordprocessing.INumberingFormat? NumberingFormat { get ; set; }

  public ILevelRestart? LevelRestart { get ; set; }

  public IParagraphStyleIdInLevel? ParagraphStyleIdInLevel { get ; set; }

  public IIsLegalNumberingStyle? IsLegalNumberingStyle { get ; set; }

  public ILevelSuffix? LevelSuffix { get ; set; }

  public ILevelText? LevelText { get ; set; }

  public ILevelPictureBulletId? LevelPictureBulletId { get ; set; }

  public ILegacyNumbering? LegacyNumbering { get ; set; }

  public ILevelJustification? LevelJustification { get ; set; }

  public IPreviousParagraphProperties? PreviousParagraphProperties { get ; set; }

  public INumberingSymbolRunProperties? NumberingSymbolRunProperties { get ; set; }

}
