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
      var element = _Element?.GetFirstChild<DXW.PictureBulletBase>();
      if (element != null)
        return PictureBulletBaseConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PictureBulletBase>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureBulletBaseConverter.CreateOpenXmlElement<DXW.PictureBulletBase>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Drawing>();
      if (element != null)
        return DrawingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Drawing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DrawingConverter.CreateOpenXmlElement<DXW.Drawing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
