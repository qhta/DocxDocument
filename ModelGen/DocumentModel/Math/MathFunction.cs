namespace DocumentModel.Math;


/// <summary>
///   Function Apply Function.
/// </summary>
public partial class MathFunction: ModelElement<DXM.MathFunction>
{
  public MathFunction(): base(){ }
  
  public MathFunction(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MathFunction(DXM.MathFunction openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Function Properties.
  /// </summary>
  [DataMember]
  public DMM.FunctionProperties? FunctionProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.FunctionProperties>();
      if (element != null)
        return FunctionPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.FunctionProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FunctionPropertiesConverter.CreateOpenXmlElement<DXM.FunctionProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Function Name.
  /// </summary>
  [DataMember]
  public DMM.FunctionName? FunctionName
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.FunctionName>();
      if (element != null)
        return FunctionNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.FunctionName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FunctionNameConverter.CreateOpenXmlElement<DXM.FunctionName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Base (Argument).
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
