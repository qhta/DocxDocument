namespace DocumentModel.Math;


/// <summary>
///   Upper-Limit Function.
/// </summary>
public partial class LimitUpper: ModelElement<DXM.LimitUpper>
{
  public LimitUpper(): base(){ }
  
  public LimitUpper(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LimitUpper(DXM.LimitUpper openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Upper Limit Properties.
  /// </summary>
  [DataMember]
  public DMM.LimitUpperProperties? LimitUpperProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.LimitUpperProperties>();
      if (element != null)
        return LimitUpperPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.LimitUpperProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LimitUpperPropertiesConverter.CreateOpenXmlElement<DXM.LimitUpperProperties>(value);
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
  ///   Limit (Upper).
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
