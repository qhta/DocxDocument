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
        _ExistingElement.HideGeometry = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.LockedText = new DX.BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.BlipPlaceholder = new DX.BooleanValue { Value = (Boolean)value };
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
      return _Element?.GetObject<DMDD.AdjustList,DXDDD.AdjustList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.AdjustList,DXDDD.AdjustList>(value);
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
      return _Element?.GetObject<DMDD.ExtensionList,DXDDD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.ExtensionList,DXDDD.ExtensionList>(value);
    }
  }
  
}
