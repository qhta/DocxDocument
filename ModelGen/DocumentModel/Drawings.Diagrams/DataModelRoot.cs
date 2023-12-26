namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Data Model.
/// </summary>
public partial class DataModelRoot: ModelElement<DXDDD.DataModelRoot>
{
  public DataModelRoot(): base(){ }
  
  public DataModelRoot(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataModelRoot(DXDDD.DataModelRoot openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Point List.
  /// </summary>
  [DataMember]
  public DMDD.PointList? PointList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Connection List.
  /// </summary>
  [DataMember]
  public DMDD.ConnectionList? ConnectionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Background Formatting.
  /// </summary>
  [DataMember]
  public DMDD.Background? Background
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Whole E2O Formatting.
  /// </summary>
  [DataMember]
  public DMDD.Whole? Whole
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   DataModelExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.DataModelExtensionList? DataModelExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
