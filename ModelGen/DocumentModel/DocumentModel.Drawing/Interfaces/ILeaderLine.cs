namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LeaderLine Class.
/// </summary>
public interface ILeaderLine // : DocumentModel.Drawing.IStyleEntry
{
  public DocumentModel.Drawing.ILineReference? LineReference { get ; set; }
  
  public System.String? LineWidthScale { get ; set; }
  
  public DocumentModel.Drawing.IFillReference? FillReference { get ; set; }
  
  public DocumentModel.Drawing.IEffectReference? EffectReference { get ; set; }
  
  public DocumentModel.Drawing.IFontReference? FontReference { get ; set; }
  
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.ITextCharacterPropertiesType? TextCharacterPropertiesType { get ; set; }
  
  public DocumentModel.Drawing.ITextBodyProperties? TextBodyProperties { get ; set; }
  
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
