namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Shape Definition.
/// </summary>
public partial class Shape: ModelElement<DXDCD.Shape>
{
  public Shape(): base(){ }
  
  public Shape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shape(DXDCD.Shape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  [DataMember]
  public String? Macro
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Macro);
    }
    set
    {
      _ExistingElement.Macro = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Text Link
  /// </summary>
  [DataMember]
  public String? TextLink
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.TextLink);
    }
    set
    {
      _ExistingElement.TextLink = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Lock Text
  /// </summary>
  [DataMember]
  public Boolean? LockText
  {
    get
    {
      return _Element?.LockText?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.LockText = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.LockText = null;
    }
  }
  
  
  /// <summary>
  ///   Publish to Server
  /// </summary>
  [DataMember]
  public Boolean? Published
  {
    get
    {
      return _Element?.Published?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Published = null;
    }
  }
  
  
  /// <summary>
  ///   Non-Visual Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualShapeProperties? NonVisualShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.NonVisualShapeProperties>();
      if (element != null)
        return NonVisualShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.NonVisualShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualShapePropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXDCD.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shape Style.
  /// </summary>
  [DataMember]
  public DMDCD.Style? Style
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.Style>();
      if (element != null)
        return StyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleConverter.CreateOpenXmlElement<DXDCD.Style>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shape Text Body.
  /// </summary>
  [DataMember]
  public DMDCD.TextBody? TextBody
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.TextBody>();
      if (element != null)
        return TextBodyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.TextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBodyConverter.CreateOpenXmlElement<DXDCD.TextBody>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
