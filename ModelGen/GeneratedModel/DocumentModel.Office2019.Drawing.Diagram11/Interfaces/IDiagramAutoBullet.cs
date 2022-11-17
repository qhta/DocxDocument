namespace DocumentModel.Office2019.Drawing.Diagram11;

public interface IDiagramAutoBullet // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? AutoBulletPrefix { get ; set; }
  
  public bool? LeadZeros { get ; set; }
  
  public INoBullet? NoBullet { get ; set; }
  
  public IAutoNumberedBullet? AutoNumberedBullet { get ; set; }
  
  public ICharacterBullet? CharacterBullet { get ; set; }
  
  public IPictureBullet? PictureBullet { get ; set; }
  
}
