namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PictureBulletBase Class.
/// </summary>
public partial class PictureBulletBase: ModelElement<DXW.PictureBulletBase>
{
  public PictureBulletBase(): base(){ }
  
  public PictureBulletBase(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PictureBulletBase(DXW.PictureBulletBase openXmlElement): base(openXmlElement) { }
  
}
