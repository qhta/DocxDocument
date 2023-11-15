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
    get => _Element?.ModelId;
    set => _ExistingElement.ModelId = value;
  }
  
  
  /// <summary>
  ///   Connection Identifier
  /// </summary>
  [DataMember]
  public String? ConnectionId
  {
    get => _Element?.ConnectionId;
    set => _ExistingElement.ConnectionId = value;
  }
  
  
  /// <summary>
  ///   Property Set.
  /// </summary>
  [DataMember]
  public DMDD.PropertySet? PropertySet
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  [DataMember]
  public DMDD.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Text Body.
  /// </summary>
  [DataMember]
  public DMDD.TextBody? TextBody
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   PtExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.PtExtensionList? PtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
