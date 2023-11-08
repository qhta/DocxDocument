namespace DocumentModel.Drawings;


/// <summary>
///   Defines the DefaultShapeDefinitionType Class.
/// </summary>
public partial class DefaultShapeDefinitionType: ModelElement<DXD.DefaultShapeDefinitionType>
{
  public DefaultShapeDefinitionType(): base(){ }
  
  public DefaultShapeDefinitionType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DefaultShapeDefinitionType(DXD.DefaultShapeDefinitionType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Visual Properties.
  /// </summary>
  [DataMember]
  public DMD.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXD.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   BodyProperties.
  /// </summary>
  [DataMember]
  public DMD.BodyProperties? BodyProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BodyProperties>();
      if (element != null)
        return BodyPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BodyProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BodyPropertiesConverter.CreateOpenXmlElement<DXD.BodyProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ListStyle.
  /// </summary>
  [DataMember]
  public DMD.ListStyle? ListStyle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ListStyle>();
      if (element != null)
        return ListStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ListStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ListStyleConverter.CreateOpenXmlElement<DXD.ListStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ShapeStyle.
  /// </summary>
  [DataMember]
  public DMD.ShapeStyle? ShapeStyle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ShapeStyle>();
      if (element != null)
        return ShapeStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ShapeStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeStyleConverter.CreateOpenXmlElement<DXD.ShapeStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
