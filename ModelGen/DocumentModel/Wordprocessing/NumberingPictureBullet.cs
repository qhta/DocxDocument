namespace DocumentModel.Wordprocessing;


/// <summary>
///   Picture Numbering Symbol Definition.
/// </summary>
public partial class NumberingPictureBullet: ModelElement<DXW.NumberingPictureBullet>
{
  public NumberingPictureBullet(): base(){ }
  
  public NumberingPictureBullet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingPictureBullet(DXW.NumberingPictureBullet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   numPicBulletId
  /// </summary>
  [DataMember]
  public Int32? NumberingPictureBulletId
  {
    get
    {
      return _Element?.NumberingPictureBulletId?.Value;
    }
    set
    {
      _ExistingElement.NumberingPictureBulletId = value;
    }
  }
  
  
  /// <summary>
  ///   PictureBulletBase.
  /// </summary>
  [DataMember]
  public DMW.PictureBulletBase? PictureBulletBase
  {
    get
    {
      return _Element?.GetObject<DMW.PictureBulletBase,DXW.PictureBulletBase>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PictureBulletBase,DXW.PictureBulletBase>(value);
    }
  }
  
  
  /// <summary>
  ///   Drawing.
  /// </summary>
  [DataMember]
  public DMW.Drawing? Drawing
  {
    get
    {
      return _Element?.GetObject<DMW.Drawing,DXW.Drawing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Drawing,DXW.Drawing>(value);
    }
  }
  
}
