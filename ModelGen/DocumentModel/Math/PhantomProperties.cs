namespace DocumentModel.Math;


/// <summary>
///   Phantom Properties.
/// </summary>
public partial class PhantomProperties: ModelElement<DXM.PhantomProperties>
{
  public PhantomProperties(): base(){ }
  
  public PhantomProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PhantomProperties(DXM.PhantomProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Phantom Show.
  /// </summary>
  [DataMember]
  public DMM.ShowPhantom? ShowPhantom
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ShowPhantom>();
      if (element != null)
        return ShowPhantomConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ShowPhantom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowPhantomConverter.CreateOpenXmlElement<DXM.ShowPhantom>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Phantom Zero Width.
  /// </summary>
  [DataMember]
  public DMM.ZeroWidth? ZeroWidth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ZeroWidth>();
      if (element != null)
        return ZeroWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ZeroWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ZeroWidthConverter.CreateOpenXmlElement<DXM.ZeroWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Phantom Zero Ascent.
  /// </summary>
  [DataMember]
  public DMM.ZeroAscent? ZeroAscent
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ZeroAscent>();
      if (element != null)
        return ZeroAscentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ZeroAscent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ZeroAscentConverter.CreateOpenXmlElement<DXM.ZeroAscent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Phantom Zero Descent.
  /// </summary>
  [DataMember]
  public DMM.ZeroDescent? ZeroDescent
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ZeroDescent>();
      if (element != null)
        return ZeroDescentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ZeroDescent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ZeroDescentConverter.CreateOpenXmlElement<DXM.ZeroDescent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Transparent (Phantom).
  /// </summary>
  [DataMember]
  public DMM.Transparent? Transparent
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Transparent>();
      if (element != null)
        return TransparentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Transparent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TransparentConverter.CreateOpenXmlElement<DXM.Transparent>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
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
