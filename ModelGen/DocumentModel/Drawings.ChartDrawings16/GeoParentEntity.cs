namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoParentEntity Class.
/// </summary>
public partial class GeoParentEntity: ModelElement<DXO16DCD.GeoParentEntity>
{
  public GeoParentEntity(): base(){ }
  
  public GeoParentEntity(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoParentEntity(DXO16DCD.GeoParentEntity openXmlElement): base(openXmlElement) { }
  
  
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
