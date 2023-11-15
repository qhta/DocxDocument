namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Data Model.
/// </summary>
public partial class DataModel: ModelElement<DXDDD.DataModel>
{
  public DataModel(): base(){ }
  
  public DataModel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataModel(DXDDD.DataModel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Point List.
  /// </summary>
  [DataMember]
  public DMDD.PointList? PointList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Connection List.
  /// </summary>
  [DataMember]
  public DMDD.ConnectionList? ConnectionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Background Formatting.
  /// </summary>
  [DataMember]
  public DMDD.Background? Background
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Whole E2O Formatting.
  /// </summary>
  [DataMember]
  public DMDD.Whole? Whole
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   DataModelExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.DataModelExtensionList? DataModelExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
