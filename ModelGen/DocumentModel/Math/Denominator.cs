namespace DocumentModel.Math;


/// <summary>
///   Denominator.
/// </summary>
public partial class Denominator: ModelElement<DXM.Denominator>
{
  public Denominator(): base(){ }
  
  public Denominator(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Denominator(DXM.Denominator openXmlElement): base(openXmlElement) { }
  
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
