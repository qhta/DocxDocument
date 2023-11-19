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
  public DocumentModel.HexInt? PresentationElementId
  {
    get => HexIntConverter.GetValue(_Element?.PresentationElementId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Presentation Name
  /// </summary>
  [DataMember]
  public String? PresentationName
  {
    get => _Element?.PresentationName;
    set => _ExistingElement.PresentationName = value;
  }
  
  
  /// <summary>
  ///   Presentation Style Label
  /// </summary>
  [DataMember]
  public String? PresentationStyleLabel
  {
    get => _Element?.PresentationStyleLabel;
    set => _ExistingElement.PresentationStyleLabel = value;
  }
  
  
  /// <summary>
  ///   Presentation Style Index
  /// </summary>
  [DataMember]
  public Int32? PresentationStyleIndex
  {
    get => _Element?.PresentationStyleIndex?.Value;
    set => _ExistingElement.PresentationStyleIndex = value;
  }
  
  
  /// <summary>
  ///   Presentation Style Count
  /// </summary>
  [DataMember]
  public Int32? PresentationStyleCount
  {
    get => _Element?.PresentationStyleCount?.Value;
    set => _ExistingElement.PresentationStyleCount = value;
  }
  
  
  /// <summary>
  ///   Current Diagram Type
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? LayoutTypeId
  {
    get => HexIntConverter.GetValue(_Element?.LayoutTypeId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Current Diagram Category
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? LayoutCategoryId
  {
    get => HexIntConverter.GetValue(_Element?.LayoutCategoryId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Current Style Type
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? QuickStyleTypeId
  {
    get => HexIntConverter.GetValue(_Element?.QuickStyleTypeId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Current Style Category
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? QuickStyleCategoryId
  {
    get => HexIntConverter.GetValue(_Element?.QuickStyleCategoryId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Color Transform Type Identifier
  /// </summary>
  [DataMember]
  public String? ColorType
  {
    get => _Element?.ColorType;
    set => _ExistingElement.ColorType = value;
  }
  
  
  /// <summary>
  ///   Color Transform Category
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ColorCategoryId
  {
    get => HexIntConverter.GetValue(_Element?.ColorCategoryId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Coherent 3D Behavior
  /// </summary>
  [DataMember]
  public Boolean? Coherent3D
  {
    get => _Element?.Coherent3D?.Value;
    set => _ExistingElement.Coherent3D = value;
  }
  
  
  /// <summary>
  ///   Placeholder Text
  /// </summary>
  [DataMember]
  public String? PlaceholderText
  {
    get => _Element?.PlaceholderText;
    set => _ExistingElement.PlaceholderText = value;
  }
  
  
  /// <summary>
  ///   Placeholder
  /// </summary>
  [DataMember]
  public Boolean? Placeholder
  {
    get => _Element?.Placeholder?.Value;
    set => _ExistingElement.Placeholder = value;
  }
  
  
  /// <summary>
  ///   Custom Rotation
  /// </summary>
  [DataMember]
  public Int32? Rotation
  {
    get => _Element?.Rotation?.Value;
    set => _ExistingElement.Rotation = value;
  }
  
  
  /// <summary>
  ///   Custom Vertical Flip
  /// </summary>
  [DataMember]
  public Boolean? VerticalFlip
  {
    get => _Element?.VerticalFlip?.Value;
    set => _ExistingElement.VerticalFlip = value;
  }
  
  
  /// <summary>
  ///   Custom Horizontal Flip
  /// </summary>
  [DataMember]
  public Boolean? HorizontalFlip
  {
    get => _Element?.HorizontalFlip?.Value;
    set => _ExistingElement.HorizontalFlip = value;
  }
  
  
  /// <summary>
  ///   Fixed Width Override
  /// </summary>
  [DataMember]
  public Int32? FixedWidthOverride
  {
    get => _Element?.FixedWidthOverride?.Value;
    set => _ExistingElement.FixedWidthOverride = value;
  }
  
  
  /// <summary>
  ///   Fixed Height Override
  /// </summary>
  [DataMember]
  public Int32? FixedHeightOverride
  {
    get => _Element?.FixedHeightOverride?.Value;
    set => _ExistingElement.FixedHeightOverride = value;
  }
  
  
  /// <summary>
  ///   Width Scale
  /// </summary>
  [DataMember]
  public Int32? WidthScale
  {
    get => _Element?.WidthScale?.Value;
    set => _ExistingElement.WidthScale = value;
  }
  
  
  /// <summary>
  ///   Height Scale
  /// </summary>
  [DataMember]
  public Int32? HightScale
  {
    get => _Element?.HightScale?.Value;
    set => _ExistingElement.HightScale = value;
  }
  
  
  /// <summary>
  ///   Text Changed
  /// </summary>
  [DataMember]
  public Boolean? TextChanged
  {
    get => _Element?.TextChanged?.Value;
    set => _ExistingElement.TextChanged = value;
  }
  
  
  /// <summary>
  ///   Custom Factor Width
  /// </summary>
  [DataMember]
  public Int32? FactorWidth
  {
    get => _Element?.FactorWidth?.Value;
    set => _ExistingElement.FactorWidth = value;
  }
  
  
  /// <summary>
  ///   Custom Factor Height
  /// </summary>
  [DataMember]
  public Int32? FactorHeight
  {
    get => _Element?.FactorHeight?.Value;
    set => _ExistingElement.FactorHeight = value;
  }
  
  
  /// <summary>
  ///   Neighbor Offset Width
  /// </summary>
  [DataMember]
  public Int32? NeighborOffsetWidth
  {
    get => _Element?.NeighborOffsetWidth?.Value;
    set => _ExistingElement.NeighborOffsetWidth = value;
  }
  
  
  /// <summary>
  ///   Neighbor Offset Height
  /// </summary>
  [DataMember]
  public Int32? NeighborOffsetHeight
  {
    get => _Element?.NeighborOffsetHeight?.Value;
    set => _ExistingElement.NeighborOffsetHeight = value;
  }
  
  
  /// <summary>
  ///   Radius Scale
  /// </summary>
  [DataMember]
  public Int32? RadiusScale
  {
    get => _Element?.RadiusScale?.Value;
    set => _ExistingElement.RadiusScale = value;
  }
  
  
  /// <summary>
  ///   Include Angle Scale
  /// </summary>
  [DataMember]
  public Int32? IncludeAngleScale
  {
    get => _Element?.IncludeAngleScale?.Value;
    set => _ExistingElement.IncludeAngleScale = value;
  }
  
  
  /// <summary>
  ///   Presentation Layout Variables.
  /// </summary>
  [DataMember]
  public DMDD.PresentationLayoutVariables? PresentationLayoutVariables
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType");
  }
  
  
  /// <summary>
  ///   Shape Style.
  /// </summary>
  [DataMember]
  public DMDD.Style? Style
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
