namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Connection.
/// </summary>
public partial class Connection: ModelElement<DXDDD.Connection>
{
  public Connection(): base(){ }
  
  public Connection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Connection(DXDDD.Connection openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Model Identifier
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ModelId
  {
    get => HexIntConverter.GetValue(_Element?.ModelId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Source Identifier
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? SourceId
  {
    get => HexIntConverter.GetValue(_Element?.SourceId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Destination Identifier
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? DestinationId
  {
    get => HexIntConverter.GetValue(_Element?.DestinationId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Source Position
  /// </summary>
  [DataMember]
  public UInt32? SourcePosition
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Destination Position
  /// </summary>
  [DataMember]
  public UInt32? DestinationPosition
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Parent Transition Identifier
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ParentTransitionId
  {
    get => HexIntConverter.GetValue(_Element?.ParentTransitionId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Sibling Transition Identifier
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? SiblingTransitionId
  {
    get => HexIntConverter.GetValue(_Element?.SiblingTransitionId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Presentation Identifier
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? PresentationId
  {
    get => HexIntConverter.GetValue(_Element?.PresentationId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
