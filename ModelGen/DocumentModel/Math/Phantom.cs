namespace DocumentModel.Math;


/// <summary>
///   Phantom Function.
/// </summary>
public partial class Phantom: ModelElement<DXM.Phantom>
{
  public Phantom(): base(){ }
  
  public Phantom(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Phantom(DXM.Phantom openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Phantom Properties.
  /// </summary>
  [DataMember]
  public DMM.PhantomProperties? PhantomProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.PhantomProperties>();
      if (element != null)
        return PhantomPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.PhantomProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PhantomPropertiesConverter.CreateOpenXmlElement<DXM.PhantomProperties>(value);
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
