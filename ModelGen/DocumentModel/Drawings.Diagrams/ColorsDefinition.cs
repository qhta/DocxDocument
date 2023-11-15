namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Color Transform Definitions.
/// </summary>
public partial class ColorsDefinition: ModelElement<DXDDD.ColorsDefinition>
{
  public ColorsDefinition(): base(){ }
  
  public ColorsDefinition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorsDefinition(DXDDD.ColorsDefinition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique ID
  /// </summary>
  [DataMember]
  public String? UniqueId
  {
    get => _Element?.UniqueId;
    set => _ExistingElement.UniqueId = value;
  }
  
  
  /// <summary>
  ///   Minimum Version
  /// </summary>
  [DataMember]
  public String? MinVersion
  {
    get => _Element?.MinVersion;
    set => _ExistingElement.MinVersion = value;
  }
  
  [DataMember]
  public DMDD.ColorTransformCategories? ColorTransformCategories
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
