namespace DocumentModel.Math;


/// <summary>
///   Upper Limit Properties.
/// </summary>
public partial class LimitUpperProperties: ModelElement<DXM.LimitUpperProperties>
{
  public LimitUpperProperties(): base(){ }
  
  public LimitUpperProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitUpperProperties(DXM.LimitUpperProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ControlProperties>();
      if (element != null)
        return ControlPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ControlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
