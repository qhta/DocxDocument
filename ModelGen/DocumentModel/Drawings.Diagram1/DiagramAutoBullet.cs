namespace DocumentModel.Drawings.Diagram1;


/// <summary>
///   Defines the DiagramAutoBullet Class.
/// </summary>
public partial class DiagramAutoBullet: ModelElement<DXO19DD11.DiagramAutoBullet>
{
  public DiagramAutoBullet(): base(){ }
  
  public DiagramAutoBullet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DiagramAutoBullet(DXO19DD11.DiagramAutoBullet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   prefix, this property is only available in Office 2019 and later.
  /// </summary>
  [DataMember]
  public String? AutoBulletPrefix
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AutoBulletPrefix);
    }
    set
    {
      _ExistingElement.AutoBulletPrefix = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   leadZeros, this property is only available in Office 2019 and later.
  /// </summary>
  [DataMember]
  public Boolean? LeadZeros
  {
    get
    {
      return _Element?.LeadZeros?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.LeadZeros = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.LeadZeros = null;
    }
  }
  
  
  /// <summary>
  ///   No Bullet.
  /// </summary>
  [DataMember]
  public DMD.NoBullet? NoBullet
  {
    get
    {
      return _Element?.GetObject<DMD.NoBullet,DXD.NoBullet>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.NoBullet,DXD.NoBullet>(value);
    }
  }
  
  
  /// <summary>
  ///   Auto-Numbered Bullet.
  /// </summary>
  [DataMember]
  public DMD.AutoNumberedBullet? AutoNumberedBullet
  {
    get
    {
      return _Element?.GetObject<DMD.AutoNumberedBullet,DXD.AutoNumberedBullet>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.AutoNumberedBullet,DXD.AutoNumberedBullet>(value);
    }
  }
  
  
  /// <summary>
  ///   Character Bullet.
  /// </summary>
  [DataMember]
  public DMD.CharacterBullet? CharacterBullet
  {
    get
    {
      return _Element?.GetObject<DMD.CharacterBullet,DXD.CharacterBullet>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.CharacterBullet,DXD.CharacterBullet>(value);
    }
  }
  
  
  /// <summary>
  ///   Picture Bullet.
  /// </summary>
  [DataMember]
  public DMD.PictureBullet? PictureBullet
  {
    get
    {
      return _Element?.GetObject<DMD.PictureBullet,DXD.PictureBullet>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PictureBullet,DXD.PictureBullet>(value);
    }
  }
  
}
