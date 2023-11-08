namespace DocumentModel.Math;


/// <summary>
///   Lower Limit Properties.
/// </summary>
public partial class LimitLowerProperties: ModelElement<DXM.LimitLowerProperties>
{
  public LimitLowerProperties(): base(){ }
  
  public LimitLowerProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitLowerProperties(DXM.LimitLowerProperties openXmlElement): base(openXmlElement) { }
  
  
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
