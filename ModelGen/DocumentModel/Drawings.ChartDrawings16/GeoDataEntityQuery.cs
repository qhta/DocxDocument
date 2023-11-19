namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoDataEntityQuery Class.
/// </summary>
public partial class GeoDataEntityQuery: ModelElement<DXO16DCD.GeoDataEntityQuery>
{
  public GeoDataEntityQuery(): base(){ }
  
  public GeoDataEntityQuery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoDataEntityQuery(DXO16DCD.GeoDataEntityQuery openXmlElement): base(openXmlElement) { }
  
  
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
