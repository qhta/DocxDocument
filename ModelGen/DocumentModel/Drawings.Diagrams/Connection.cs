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
  public String? ModelId
  {
    get => _Element?.ModelId;
    set => _ExistingElement.ModelId = value;
  }
  
  
  /// <summary>
  ///   Source Identifier
  /// </summary>
  [DataMember]
  public String? SourceId
  {
    get => _Element?.SourceId;
    set => _ExistingElement.SourceId = value;
  }
  
  
  /// <summary>
  ///   Destination Identifier
  /// </summary>
  [DataMember]
  public String? DestinationId
  {
    get => _Element?.DestinationId;
    set => _ExistingElement.DestinationId = value;
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
  public String? ParentTransitionId
  {
    get => _Element?.ParentTransitionId;
    set => _ExistingElement.ParentTransitionId = value;
  }
  
  
  /// <summary>
  ///   Sibling Transition Identifier
  /// </summary>
  [DataMember]
  public String? SiblingTransitionId
  {
    get => _Element?.SiblingTransitionId;
    set => _ExistingElement.SiblingTransitionId = value;
  }
  
  
  /// <summary>
  ///   Presentation Identifier
  /// </summary>
  [DataMember]
  public String? PresentationId
  {
    get => _Element?.PresentationId;
    set => _ExistingElement.PresentationId = value;
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
