namespace DocumentModel.Math;


/// <summary>
///   n-ary Properties.
/// </summary>
public partial class NaryProperties: ModelElement<DXM.NaryProperties>
{
  public NaryProperties(): base(){ }
  
  public NaryProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NaryProperties(DXM.NaryProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   n-ary Operator Character.
  /// </summary>
  [DataMember]
  public DMM.AccentChar? AccentChar
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.AccentChar>();
      if (element != null)
        return AccentCharConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.AccentChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AccentCharConverter.CreateOpenXmlElement<DXM.AccentChar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   n-ary Limit Location.
  /// </summary>
  [DataMember]
  public DMM.LimitLocation? LimitLocation
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.LimitLocation>();
      if (element != null)
        return LimitLocationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.LimitLocation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LimitLocationConverter.CreateOpenXmlElement<DXM.LimitLocation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   n-ary Grow.
  /// </summary>
  [DataMember]
  public DMM.GrowOperators? GrowOperators
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.GrowOperators>();
      if (element != null)
        return GrowOperatorsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.GrowOperators>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GrowOperatorsConverter.CreateOpenXmlElement<DXM.GrowOperators>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Hide Subscript (n-ary).
  /// </summary>
  [DataMember]
  public DMM.HideSubArgument? HideSubArgument
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.HideSubArgument>();
      if (element != null)
        return HideSubArgumentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.HideSubArgument>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HideSubArgumentConverter.CreateOpenXmlElement<DXM.HideSubArgument>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Hide Superscript (n-ary).
  /// </summary>
  [DataMember]
  public DMM.HideSuperArgument? HideSuperArgument
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.HideSuperArgument>();
      if (element != null)
        return HideSuperArgumentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.HideSuperArgument>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HideSuperArgumentConverter.CreateOpenXmlElement<DXM.HideSuperArgument>(value);
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
