namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Marker.
/// </summary>
public partial class Marker: ModelElement<DXDC.Marker>
{
  public Marker(): base(){ }
  
  public Marker(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Marker(DXDC.Marker openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Symbol.
  /// </summary>
  [DataMember]
  public DMDC.MarkerStyleKind? Symbol
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Size.
  /// </summary>
  [DataMember]
  public Byte? Size
  {
    get => _Element?.GetIntVal<Byte, DXDC.Size>();
    set => _ExistingElement.SetIntVal<Byte, DXDC.Size>(value);
  }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
