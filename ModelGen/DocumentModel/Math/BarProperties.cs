namespace DocumentModel.Math;


/// <summary>
///   Bar Properties.
/// </summary>
public partial class BarProperties: ModelElement<DXM.BarProperties>
{
  public BarProperties(): base(){ }
  
  public BarProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BarProperties(DXM.BarProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Position (Bar).
  /// </summary>
  [DataMember]
  public DMM.Position? Position
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Position>();
      if (element != null)
        return PositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Position>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PositionConverter.CreateOpenXmlElement<DXM.Position>(value);
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
