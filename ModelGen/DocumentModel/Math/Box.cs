namespace DocumentModel.Math;


/// <summary>
///   Box Function.
/// </summary>
public partial class Box: ModelElement<DXM.Box>
{
  public Box(): base(){ }
  
  public Box(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Box(DXM.Box openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Box Properties.
  /// </summary>
  [DataMember]
  public DMM.BoxProperties? BoxProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.BoxProperties>();
      if (element != null)
        return BoxPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.BoxProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BoxPropertiesConverter.CreateOpenXmlElement<DXM.BoxProperties>(value);
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
