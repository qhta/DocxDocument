namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the DiagramDefinitionExtension Class.
/// </summary>
public partial class DiagramDefinitionExtension: ModelElement<DXDDD.DiagramDefinitionExtension>
{
  public DiagramDefinitionExtension(): base(){ }
  
  public DiagramDefinitionExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DiagramDefinitionExtension(DXDDD.DiagramDefinitionExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
  [DataMember]
  public DMDD1.NumberDiagramInfoList? NumberDiagramInfoList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDD2.TextListStyleType? TextListStyleType
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
