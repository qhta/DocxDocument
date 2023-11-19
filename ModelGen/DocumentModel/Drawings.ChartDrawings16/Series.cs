namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Series Class.
/// </summary>
public partial class Series: ModelElement<DXO16DCD.Series>
{
  public Series(): base(){ }
  
  public Series(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Series(DXO16DCD.Series openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? LayoutId
  {
    get => HexIntConverter.GetValue(_Element?.LayoutId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   hidden, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Hidden
  {
    get => _Element?.Hidden?.Value;
    set => _ExistingElement.Hidden = value;
  }
  
  
  /// <summary>
  ///   ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? OwnerIdx
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? UniqueId
  {
    get => HexIntConverter.GetValue(_Element?.UniqueId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? FormatIdx
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Text.
  /// </summary>
  [DataMember]
  public DMDCD16.Text? Text
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ValueColors.
  /// </summary>
  [DataMember]
  public DMDCD16.ValueColors? ValueColors
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ValueColorPositions.
  /// </summary>
  [DataMember]
  public DMDCD16.ValueColorPositions? ValueColorPositions
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDCD16.DataLabels? DataLabels
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DocumentModel.HexInt? DataId
  {
    get => _Element?.GetHexIntVal<DXO16DCD.DataId>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  [DataMember]
  public DMDCD16.SeriesLayoutProperties? SeriesLayoutProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
