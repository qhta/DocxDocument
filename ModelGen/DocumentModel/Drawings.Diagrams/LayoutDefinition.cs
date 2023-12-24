namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Layout Definition.
/// </summary>
public partial class LayoutDefinition: ModelElement<DXDDD.LayoutDefinition>
{
  public LayoutDefinition(): base(){ }
  
  public LayoutDefinition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LayoutDefinition(DXDDD.LayoutDefinition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   uniqueId
  /// </summary>
  [DataMember]
  public String? UniqueId
  {
    get => _Element?.UniqueId;
    set => _ExistingElement.UniqueId = value;
  }
  
  
  /// <summary>
  ///   minVer
  /// </summary>
  [DataMember]
  public String? MinVersion
  {
    get => _Element?.MinVersion;
    set => _ExistingElement.MinVersion = value;
  }
  
  
  /// <summary>
  ///   defStyle
  /// </summary>
  [DataMember]
  public String? DefaultStyle
  {
    get => _Element?.DefaultStyle;
    set => _ExistingElement.DefaultStyle = value;
  }
  
  [DataMember]
  public DMDD.CategoryList? CategoryList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDD.SampleData? SampleData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType");
  }
  
  [DataMember]
  public DMDD.StyleData? StyleData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType");
  }
  
  [DataMember]
  public DMDD.ColorData? ColorData
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType");
  }
  
  [DataMember]
  public DMDD.LayoutNode? LayoutNode
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDD.DiagramDefinitionExtensionList? DiagramDefinitionExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
