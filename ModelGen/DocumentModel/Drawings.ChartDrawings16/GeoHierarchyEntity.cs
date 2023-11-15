namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoHierarchyEntity Class.
/// </summary>
public partial class GeoHierarchyEntity: ModelElement<DXO16DCD.GeoHierarchyEntity>
{
  public GeoHierarchyEntity(): base(){ }
  
  public GeoHierarchyEntity(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoHierarchyEntity(DXO16DCD.GeoHierarchyEntity openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? EntityName
  {
    get => _Element?.EntityName;
    set => _ExistingElement.EntityName = value;
  }
  
  
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? EntityId
  {
    get => _Element?.EntityId;
    set => _ExistingElement.EntityId = value;
  }
  
}
