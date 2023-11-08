namespace DocumentModel.Math;


/// <summary>
///   Border-Box Function.
/// </summary>
public partial class BorderBox: ModelElement<DXM.BorderBox>
{
  public BorderBox(): base(){ }
  
  public BorderBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BorderBox(DXM.BorderBox openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Border Box Properties.
  /// </summary>
  [DataMember]
  public DMM.BorderBoxProperties? BorderBoxProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.BorderBoxProperties>();
      if (element != null)
        return BorderBoxPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.BorderBoxProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderBoxPropertiesConverter.CreateOpenXmlElement<DXM.BorderBoxProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  [DataMember]
  public DMM.Base? Base
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Base>();
      if (element != null)
        return BaseConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Base>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BaseConverter.CreateOpenXmlElement<DXM.Base>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
