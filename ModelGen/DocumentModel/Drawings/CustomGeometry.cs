namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the existence of a custom geometric shape. This shape consists of a series of lines and curves described within a creation path. In addition to this there can also be adjust values, guides, adjust handles, connection sites and an inscribed rectangle specified for this custom geometric shape.
/// </summary>
public partial class CustomGeometry: ModelElement<DXD.CustomGeometry>
{
  public CustomGeometry(): base(){ }
  
  public CustomGeometry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomGeometry(DXD.CustomGeometry openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Adjust Value List.
  /// </summary>
  [DataMember]
  public DMD.AdjustValueList? AdjustValueList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.GeometryGuideListType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.GeometryGuideListType");
  }
  
  
  /// <summary>
  ///   List of Shape Guides.
  /// </summary>
  [DataMember]
  public DMD.ShapeGuideList? ShapeGuideList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.GeometryGuideListType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.GeometryGuideListType");
  }
  
  
  /// <summary>
  ///   List of Shape Adjust Handles.
  /// </summary>
  [DataMember]
  public DMD.AdjustHandleList? AdjustHandleList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   List of Shape Connection Sites.
  /// </summary>
  [DataMember]
  public DMD.ConnectionSiteList? ConnectionSiteList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Shape Text Rectangle.
  /// </summary>
  [DataMember]
  public DMD.Rectangle? Rectangle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   List of Shape Paths.
  /// </summary>
  [DataMember]
  public DMD.PathList? PathList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
