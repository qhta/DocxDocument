namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoParentEntitiesQuery Class.
/// </summary>
public partial class GeoParentEntitiesQuery: ModelElement<DXO16DCD.GeoParentEntitiesQuery>
{
  public GeoParentEntitiesQuery(): base(){ }
  
  public GeoParentEntitiesQuery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoParentEntitiesQuery(DXO16DCD.GeoParentEntitiesQuery openXmlElement): base(openXmlElement) { }
  
  
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
