namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Property Set.
/// </summary>
public partial class PropertySet: ModelElement<DXDDD.PropertySet>
{
  public PropertySet(): base(){ }
  
  public PropertySet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PropertySet(DXDDD.PropertySet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Presentation Element Identifier
  /// </summary>
  [DataMember]
  public String? PresentationElementId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.PresentationElementId);
    }
    set
    {
      _ExistingElement.PresentationElementId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Presentation Name
  /// </summary>
  [DataMember]
  public String? PresentationName
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.PresentationName);
    }
    set
    {
      _ExistingElement.PresentationName = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Presentation Style Label
  /// </summary>
  [DataMember]
  public String? PresentationStyleLabel
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.PresentationStyleLabel);
    }
    set
    {
      _ExistingElement.PresentationStyleLabel = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Presentation Style Index
  /// </summary>
  [DataMember]
  public Int32? PresentationStyleIndex
  {
    get
    {
      return _Element?.PresentationStyleIndex?.Value;
    }
    set
    {
      _ExistingElement.PresentationStyleIndex = value;
    }
  }
  
  
  /// <summary>
  ///   Presentation Style Count
  /// </summary>
  [DataMember]
  public Int32? PresentationStyleCount
  {
    get
    {
      return _Element?.PresentationStyleCount?.Value;
    }
    set
    {
      _ExistingElement.PresentationStyleCount = value;
    }
  }
  
  
  /// <summary>
  ///   Current Diagram Type
  /// </summary>
  [DataMember]
  public String? LayoutTypeId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LayoutTypeId);
    }
    set
    {
      _ExistingElement.LayoutTypeId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Current Diagram Category
  /// </summary>
  [DataMember]
  public String? LayoutCategoryId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LayoutCategoryId);
    }
    set
    {
      _ExistingElement.LayoutCategoryId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Current Style Type
  /// </summary>
  [DataMember]
  public String? QuickStyleTypeId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.QuickStyleTypeId);
    }
    set
    {
      _ExistingElement.QuickStyleTypeId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Current Style Category
  /// </summary>
  [DataMember]
  public String? QuickStyleCategoryId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.QuickStyleCategoryId);
    }
    set
    {
      _ExistingElement.QuickStyleCategoryId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Color Transform Type Identifier
  /// </summary>
  [DataMember]
  public String? ColorType
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ColorType);
    }
    set
    {
      _ExistingElement.ColorType = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Color Transform Category
  /// </summary>
  [DataMember]
  public String? ColorCategoryId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ColorCategoryId);
    }
    set
    {
      _ExistingElement.ColorCategoryId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Coherent 3D Behavior
  /// </summary>
  [DataMember]
  public Boolean? Coherent3D
  {
    get
    {
      return _Element?.Coherent3D?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Coherent3D = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Coherent3D = null;
    }
  }
  
  
  /// <summary>
  ///   Placeholder Text
  /// </summary>
  [DataMember]
  public String? PlaceholderText
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.PlaceholderText);
    }
    set
    {
      _ExistingElement.PlaceholderText = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Placeholder
  /// </summary>
  [DataMember]
  public Boolean? Placeholder
  {
    get
    {
      return _Element?.Placeholder?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Placeholder = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Placeholder = null;
    }
  }
  
  
  /// <summary>
  ///   Custom Rotation
  /// </summary>
  [DataMember]
  public Int32? Rotation
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
  ///   Custom Vertical Flip
  /// </summary>
  [DataMember]
  public Boolean? VerticalFlip
  {
    get
    {
      return _Element?.VerticalFlip?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.VerticalFlip = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.VerticalFlip = null;
    }
  }
  
  
  /// <summary>
  ///   Custom Horizontal Flip
  /// </summary>
  [DataMember]
  public Boolean? HorizontalFlip
  {
    get
    {
      return _Element?.HorizontalFlip?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.HorizontalFlip = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.HorizontalFlip = null;
    }
  }
  
  
  /// <summary>
  ///   Fixed Width Override
  /// </summary>
  [DataMember]
  public Int32? FixedWidthOverride
  {
    get
    {
      return _Element?.FixedWidthOverride?.Value;
    }
    set
    {
      _ExistingElement.FixedWidthOverride = value;
    }
  }
  
  
  /// <summary>
  ///   Fixed Height Override
  /// </summary>
  [DataMember]
  public Int32? FixedHeightOverride
  {
    get
    {
      return _Element?.FixedHeightOverride?.Value;
    }
    set
    {
      _ExistingElement.FixedHeightOverride = value;
    }
  }
  
  
  /// <summary>
  ///   Width Scale
  /// </summary>
  [DataMember]
  public Int32? WidthScale
  {
    get
    {
      return _Element?.WidthScale?.Value;
    }
    set
    {
      _ExistingElement.WidthScale = value;
    }
  }
  
  
  /// <summary>
  ///   Height Scale
  /// </summary>
  [DataMember]
  public Int32? HightScale
  {
    get
    {
      return _Element?.HightScale?.Value;
    }
    set
    {
      _ExistingElement.HightScale = value;
    }
  }
  
  
  /// <summary>
  ///   Text Changed
  /// </summary>
  [DataMember]
  public Boolean? TextChanged
  {
    get
    {
      return _Element?.TextChanged?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.TextChanged = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.TextChanged = null;
    }
  }
  
  
  /// <summary>
  ///   Custom Factor Width
  /// </summary>
  [DataMember]
  public Int32? FactorWidth
  {
    get
    {
      return _Element?.FactorWidth?.Value;
    }
    set
    {
      _ExistingElement.FactorWidth = value;
    }
  }
  
  
  /// <summary>
  ///   Custom Factor Height
  /// </summary>
  [DataMember]
  public Int32? FactorHeight
  {
    get
    {
      return _Element?.FactorHeight?.Value;
    }
    set
    {
      _ExistingElement.FactorHeight = value;
    }
  }
  
  
  /// <summary>
  ///   Neighbor Offset Width
  /// </summary>
  [DataMember]
  public Int32? NeighborOffsetWidth
  {
    get
    {
      return _Element?.NeighborOffsetWidth?.Value;
    }
    set
    {
      _ExistingElement.NeighborOffsetWidth = value;
    }
  }
  
  
  /// <summary>
  ///   Neighbor Offset Height
  /// </summary>
  [DataMember]
  public Int32? NeighborOffsetHeight
  {
    get
    {
      return _Element?.NeighborOffsetHeight?.Value;
    }
    set
    {
      _ExistingElement.NeighborOffsetHeight = value;
    }
  }
  
  
  /// <summary>
  ///   Radius Scale
  /// </summary>
  [DataMember]
  public Int32? RadiusScale
  {
    get
    {
      return _Element?.RadiusScale?.Value;
    }
    set
    {
      _ExistingElement.RadiusScale = value;
    }
  }
  
  
  /// <summary>
  ///   Include Angle Scale
  /// </summary>
  [DataMember]
  public Int32? IncludeAngleScale
  {
    get
    {
      return _Element?.IncludeAngleScale?.Value;
    }
    set
    {
      _ExistingElement.IncludeAngleScale = value;
    }
  }
  
  
  /// <summary>
  ///   Presentation Layout Variables.
  /// </summary>
  [DataMember]
  public DMDD.PresentationLayoutVariables? PresentationLayoutVariables
  {
    get
    {
      return _Element?.GetObject<DMDD.PresentationLayoutVariables,DXDDD.PresentationLayoutVariables>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.PresentationLayoutVariables,DXDDD.PresentationLayoutVariables>(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Style.
  /// </summary>
  [DataMember]
  public DMDD.Style? Style
  {
    get
    {
      return _Element?.GetObject<DMDD.Style,DXDDD.Style>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.Style,DXDDD.Style>(value);
    }
  }
  
}
