namespace DocumentModel.Math;


/// <summary>
///   Bar.
/// </summary>
public partial class Bar: ModelElement<DXM.Bar>
{
  public Bar(): base(){ }
  
  public Bar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Bar(DXM.Bar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Bar Properties.
  /// </summary>
  [DataMember]
  public DMM.BarProperties? BarProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.BarProperties>();
      if (element != null)
        return BarPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.BarProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BarPropertiesConverter.CreateOpenXmlElement<DXM.BarProperties>(value);
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
