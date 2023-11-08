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
        _ExistingElement.LeadZeros = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXD.NoBullet>();
      if (element != null)
        return NoBulletConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.NoBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoBulletConverter.CreateOpenXmlElement<DXD.NoBullet>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.AutoNumberedBullet>();
      if (element != null)
        return AutoNumberedBulletConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.AutoNumberedBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoNumberedBulletConverter.CreateOpenXmlElement<DXD.AutoNumberedBullet>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.CharacterBullet>();
      if (element != null)
        return CharacterBulletConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.CharacterBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CharacterBulletConverter.CreateOpenXmlElement<DXD.CharacterBullet>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.PictureBullet>();
      if (element != null)
        return PictureBulletConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PictureBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureBulletConverter.CreateOpenXmlElement<DXD.PictureBullet>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
