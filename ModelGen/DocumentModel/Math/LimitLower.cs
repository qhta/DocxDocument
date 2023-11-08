namespace DocumentModel.Math;


/// <summary>
///   Lower-Limit Function.
/// </summary>
public partial class LimitLower: ModelElement<DXM.LimitLower>
{
  public LimitLower(): base(){ }
  
  public LimitLower(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitLower(DXM.LimitLower openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Lower Limit Properties.
  /// </summary>
  [DataMember]
  public DMM.LimitLowerProperties? LimitLowerProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.LimitLowerProperties>();
      if (element != null)
        return LimitLowerPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.LimitLowerProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LimitLowerPropertiesConverter.CreateOpenXmlElement<DXM.LimitLowerProperties>(value);
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
  
  
  /// <summary>
  ///   Limit (Lower).
  /// </summary>
  [DataMember]
  public DMM.Limit? Limit
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Limit>();
      if (element != null)
        return LimitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Limit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LimitConverter.CreateOpenXmlElement<DXM.Limit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
