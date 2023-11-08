namespace DocumentModel.Word10;


/// <summary>
///   This element specifies a gradient fill. A gradient fill is a fill that is characterized by a smooth gradual transition from one color to the next.
/// </summary>
public partial class GradientFillProperties: ModelElement<DXO10W.GradientFillProperties>
{
  public GradientFillProperties(): base(){ }
  
  public GradientFillProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GradientFillProperties(DXO10W.GradientFillProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GradientStopList.
  /// </summary>
  [DataMember]
  public DMW10.GradientStopList? GradientStopList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.GradientStopList>();
      if (element != null)
        return GradientStopListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.GradientStopList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientStopListConverter.CreateOpenXmlElement<DXO10W.GradientStopList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW10.LinearShadeProperties? LinearShadeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.LinearShadeProperties>();
      if (element != null)
        return LinearShadePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.LinearShadeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LinearShadePropertiesConverter.CreateOpenXmlElement<DXO10W.LinearShadeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW10.PathShadeProperties? PathShadeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.PathShadeProperties>();
      if (element != null)
        return PathShadePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.PathShadeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PathShadePropertiesConverter.CreateOpenXmlElement<DXO10W.PathShadeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
