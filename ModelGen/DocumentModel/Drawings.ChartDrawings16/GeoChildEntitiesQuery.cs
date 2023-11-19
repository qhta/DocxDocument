namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoChildEntitiesQuery Class.
/// </summary>
public partial class GeoChildEntitiesQuery: ModelElement<DXO16DCD.GeoChildEntitiesQuery>
{
  public GeoChildEntitiesQuery(): base(){ }
  
  public GeoChildEntitiesQuery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoChildEntitiesQuery(DXO16DCD.GeoChildEntitiesQuery openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? EntityId
  {
    get => HexIntConverter.GetValue(_Element?.EntityId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   GeoChildTypes.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildTypes? GeoChildTypes
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
