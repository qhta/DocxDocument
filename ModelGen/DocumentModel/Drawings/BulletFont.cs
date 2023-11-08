namespace DocumentModel.Drawings;


/// <summary>
///   Specified.
/// </summary>
public partial class BulletFont: ModelElement<DXD.BulletFont>
{
  public BulletFont(): base(){ }
  
  public BulletFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BulletFont(DXD.BulletFont openXmlElement): base(openXmlElement) { }
  
}
