namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoDataPointToEntityQuery Class.
/// </summary>
public partial class GeoDataPointToEntityQuery: ModelElement<DXO16DCD.GeoDataPointToEntityQuery>
{
  public GeoDataPointToEntityQuery(): base(){ }
  
  public GeoDataPointToEntityQuery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoDataPointToEntityQuery(DXO16DCD.GeoDataPointToEntityQuery openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? EntityId
  {
    get => HexIntConverter.GetValue(_Element?.EntityId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
