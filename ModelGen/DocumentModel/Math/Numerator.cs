namespace DocumentModel.Math;


/// <summary>
///   Numerator.
/// </summary>
public partial class Numerator: ModelElement<DXM.Numerator>
{
  public Numerator(): base(){ }
  
  public Numerator(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Numerator(DXM.Numerator openXmlElement): base(openXmlElement) { }
  
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
