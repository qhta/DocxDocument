namespace DocumentModel.Math;


/// <summary>
///   Limit (Lower).
/// </summary>
public partial class Limit: ModelElement<DXM.Limit>
{
  public Limit(): base(){ }
  
  public Limit(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Limit(DXM.Limit openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMM.ArgumentProperties? ArgumentProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ArgumentProperties>();
      if (element != null)
        return ArgumentPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ArgumentProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArgumentPropertiesConverter.CreateOpenXmlElement<DXM.ArgumentProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
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
