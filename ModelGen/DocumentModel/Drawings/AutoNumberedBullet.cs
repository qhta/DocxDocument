namespace DocumentModel.Drawings;


/// <summary>
///   Auto-Numbered Bullet.
/// </summary>
public partial class AutoNumberedBullet: ModelElement<DXD.AutoNumberedBullet>
{
  public AutoNumberedBullet(): base(){ }
  
  public AutoNumberedBullet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AutoNumberedBullet(DXD.AutoNumberedBullet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Start Numbering At
  /// </summary>
  [DataMember]
  public Int32? StartAt
  {
    get => _Element?.StartAt?.Value;
    set => _ExistingElement.StartAt = value;
  }
  
}
