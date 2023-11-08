namespace DocumentModel.Math;


/// <summary>
///   Pre-Sub-Superscript Properties.
/// </summary>
public partial class PreSubSuperProperties: ModelElement<DXM.PreSubSuperProperties>
{
  public PreSubSuperProperties(): base(){ }
  
  public PreSubSuperProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreSubSuperProperties(DXM.PreSubSuperProperties openXmlElement): base(openXmlElement) { }
  
  
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
