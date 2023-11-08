namespace DocumentModel.Math;


/// <summary>
///   Radical Properties.
/// </summary>
public partial class RadicalProperties: ModelElement<DXM.RadicalProperties>
{
  public RadicalProperties(): base(){ }
  
  public RadicalProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RadicalProperties(DXM.RadicalProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Hide Degree.
  /// </summary>
  [DataMember]
  public DMM.HideDegree? HideDegree
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.HideDegree>();
      if (element != null)
        return HideDegreeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.HideDegree>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HideDegreeConverter.CreateOpenXmlElement<DXM.HideDegree>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
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
