namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Point.
/// </summary>
public partial class Point: ModelElement<DXDDD.Point>
{
  public Point(): base(){ }
  
  public Point(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Point(DXDDD.Point openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Model Identifier
  /// </summary>
  [DataMember]
  public String? ModelId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ModelId);
    }
    set
    {
      _ExistingElement.ModelId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Connection Identifier
  /// </summary>
  [DataMember]
  public String? ConnectionId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ConnectionId);
    }
    set
    {
      _ExistingElement.ConnectionId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Property Set.
  /// </summary>
  [DataMember]
  public DMDD.PropertySet? PropertySet
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.PropertySet>();
      if (element != null)
        return PropertySetConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.PropertySet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PropertySetConverter.CreateOpenXmlElement<DXDDD.PropertySet>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  [DataMember]
  public DMDD.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXDDD.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Text Body.
  /// </summary>
  [DataMember]
  public DMDD.TextBody? TextBody
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.TextBody>();
      if (element != null)
        return TextBodyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.TextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBodyConverter.CreateOpenXmlElement<DXDDD.TextBody>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   PtExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.PtExtensionList? PtExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.PtExtensionList>();
      if (element != null)
        return PtExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.PtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PtExtensionListConverter.CreateOpenXmlElement<DXDDD.PtExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
