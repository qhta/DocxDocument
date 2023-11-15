namespace DocumentModel.Drawings;


/// <summary>
///   Character Bullet.
/// </summary>
public partial class CharacterBullet: ModelElement<DXD.CharacterBullet>
{
  public CharacterBullet(): base(){ }
  
  public CharacterBullet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CharacterBullet(DXD.CharacterBullet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Bullet Character
  /// </summary>
  [DataMember]
  public String? Char
  {
    get => _Element?.Char;
    set => _ExistingElement.Char = value;
  }
  
}
