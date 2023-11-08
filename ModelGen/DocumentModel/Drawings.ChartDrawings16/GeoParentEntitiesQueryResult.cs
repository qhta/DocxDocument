namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public partial class GeoParentEntitiesQueryResult: ModelElement<DXO16DCD.GeoParentEntitiesQueryResult>
{
  public GeoParentEntitiesQueryResult(): base(){ }
  
  public GeoParentEntitiesQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoParentEntitiesQueryResult(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoParentEntitiesQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoParentEntitiesQuery? GeoParentEntitiesQuery
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoParentEntitiesQuery>();
      if (element != null)
        return GeoParentEntitiesQueryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoParentEntitiesQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoParentEntitiesQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoParentEntitiesQuery>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GeoEntity.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoEntity? GeoEntity
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoEntity>();
      if (element != null)
        return GeoEntityConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoEntity>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoEntityConverter.CreateOpenXmlElement<DXO16DCD.GeoEntity>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GeoParentEntity.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoParentEntity? GeoParentEntity
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoParentEntity>();
      if (element != null)
        return GeoParentEntityConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoParentEntity>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoParentEntityConverter.CreateOpenXmlElement<DXO16DCD.GeoParentEntity>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
