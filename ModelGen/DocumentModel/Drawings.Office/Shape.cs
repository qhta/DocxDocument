namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the Shape Class.
/// </summary>
public partial class Shape: ModelElement<DXOD.Shape>
{
  public Shape(): base(){ }
  
  public Shape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shape(DXOD.Shape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   modelId, this property is only available in Office 2010 and later.
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
  ///   ShapeNonVisualProperties.
  /// </summary>
  [DataMember]
  public DMDO.ShapeNonVisualProperties? ShapeNonVisualProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.ShapeNonVisualProperties>();
      if (element != null)
        return ShapeNonVisualPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.ShapeNonVisualProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DXOD.ShapeNonVisualProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDO.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXOD.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ShapeStyle.
  /// </summary>
  [DataMember]
  public DMDO.ShapeStyle? ShapeStyle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.ShapeStyle>();
      if (element != null)
        return ShapeStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.ShapeStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeStyleConverter.CreateOpenXmlElement<DXOD.ShapeStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TextBody.
  /// </summary>
  [DataMember]
  public DMDO.TextBody? TextBody
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.TextBody>();
      if (element != null)
        return TextBodyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.TextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBodyConverter.CreateOpenXmlElement<DXOD.TextBody>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Transform2D.
  /// </summary>
  [DataMember]
  public DMDO.Transform2D? Transform2D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.Transform2D>();
      if (element != null)
        return Transform2DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.Transform2D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Transform2DConverter.CreateOpenXmlElement<DXOD.Transform2D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMDO.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.OfficeArtExtensionList>();
      if (element != null)
        return OfficeArtExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DXOD.OfficeArtExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
