namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Shape.
/// </summary>
public partial class Shape: ModelElement<DXDDD.Shape>
{
  public Shape(): base(){ }
  
  public Shape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shape(DXDDD.Shape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotation
  /// </summary>
  [DataMember]
  public Double? Rotation
  {
    get
    {
      return _Element?.Rotation?.Value;
    }
    set
    {
      _ExistingElement.Rotation = value;
    }
  }
  
  
  /// <summary>
  ///   Shape Type
  /// </summary>
  [DataMember]
  public String? Type
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Type);
    }
    set
    {
      _ExistingElement.Type = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Relationship to Image Part
  /// </summary>
  [DataMember]
  public String? Blip
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Blip);
    }
    set
    {
      _ExistingElement.Blip = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Z-Order Offset
  /// </summary>
  [DataMember]
  public Int32? ZOrderOffset
  {
    get
    {
      return _Element?.ZOrderOffset?.Value;
    }
    set
    {
      _ExistingElement.ZOrderOffset = value;
    }
  }
  
  
  /// <summary>
  ///   Hide Geometry
  /// </summary>
  [DataMember]
  public Boolean? HideGeometry
  {
    get
    {
      return _Element?.HideGeometry?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.HideGeometry = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.HideGeometry = null;
    }
  }
  
  
  /// <summary>
  ///   Prevent Text Editing
  /// </summary>
  [DataMember]
  public Boolean? LockedText
  {
    get
    {
      return _Element?.LockedText?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.LockedText = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.LockedText = null;
    }
  }
  
  
  /// <summary>
  ///   Image Placeholder
  /// </summary>
  [DataMember]
  public Boolean? BlipPlaceholder
  {
    get
    {
      return _Element?.BlipPlaceholder?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.BlipPlaceholder = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.BlipPlaceholder = null;
    }
  }
  
  
  /// <summary>
  ///   Shape Adjust List.
  /// </summary>
  [DataMember]
  public DMDD.AdjustList? AdjustList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.AdjustList>();
      if (element != null)
        return AdjustListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.AdjustList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustListConverter.CreateOpenXmlElement<DXDDD.AdjustList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDDD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
