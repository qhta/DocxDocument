namespace DocumentModel.Math;


/// <summary>
///   n-ary Operator Function.
/// </summary>
public partial class Nary: ModelElement<DXM.Nary>
{
  public Nary(): base(){ }
  
  public Nary(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Nary(DXM.Nary openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   n-ary Properties.
  /// </summary>
  [DataMember]
  public DMM.NaryProperties? NaryProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.NaryProperties>();
      if (element != null)
        return NaryPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.NaryProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NaryPropertiesConverter.CreateOpenXmlElement<DXM.NaryProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Lower limit (n-ary) .
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
  ///   Upper limit (n-ary).
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
