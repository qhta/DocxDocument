namespace DocumentModel.Math;


/// <summary>
///   Subscript Function.
/// </summary>
public partial class Subscript: ModelElement<DXM.Subscript>
{
  public Subscript(): base(){ }
  
  public Subscript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Subscript(DXM.Subscript openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Subscript Properties.
  /// </summary>
  [DataMember]
  public DMM.SubscriptProperties? SubscriptProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.SubscriptProperties>();
      if (element != null)
        return SubscriptPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.SubscriptProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubscriptPropertiesConverter.CreateOpenXmlElement<DXM.SubscriptProperties>(value);
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
  ///   Subscript (Subscript function).
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
  
}
