namespace DocumentModel.Math;


/// <summary>
///   Pre-Sub-Superscript Function.
/// </summary>
public partial class PreSubSuper: ModelElement<DXM.PreSubSuper>
{
  public PreSubSuper(): base(){ }
  
  public PreSubSuper(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreSubSuper(DXM.PreSubSuper openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Pre-Sub-Superscript Properties.
  /// </summary>
  [DataMember]
  public DMM.PreSubSuperProperties? PreSubSuperProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.PreSubSuperProperties>();
      if (element != null)
        return PreSubSuperPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.PreSubSuperProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreSubSuperPropertiesConverter.CreateOpenXmlElement<DXM.PreSubSuperProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Subscript (Pre-Sub-Superscript).
  /// </summary>
  [DataMember]
  public DMM.SubArgument? SubArgument
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.SubArgument>();
      if (element != null)
        return SubArgumentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.SubArgument>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubArgumentConverter.CreateOpenXmlElement<DXM.SubArgument>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Superscript(Pre-Sub-Superscript function).
  /// </summary>
  [DataMember]
  public DMM.SuperArgument? SuperArgument
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.SuperArgument>();
      if (element != null)
        return SuperArgumentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.SuperArgument>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuperArgumentConverter.CreateOpenXmlElement<DXM.SuperArgument>(value);
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
