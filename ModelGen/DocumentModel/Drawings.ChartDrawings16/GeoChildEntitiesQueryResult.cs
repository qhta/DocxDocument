namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public partial class GeoChildEntitiesQueryResult: ModelElement<DXO16DCD.GeoChildEntitiesQueryResult>
{
  public GeoChildEntitiesQueryResult(): base(){ }
  
  public GeoChildEntitiesQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoChildEntitiesQueryResult(DXO16DCD.GeoChildEntitiesQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoChildEntitiesQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildEntitiesQuery? GeoChildEntitiesQuery
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoChildEntitiesQuery>();
      if (element != null)
        return GeoChildEntitiesQueryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoChildEntitiesQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoChildEntitiesQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoChildEntitiesQuery>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GeoChildEntities.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildEntities? GeoChildEntities
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoChildEntities>();
      if (element != null)
        return GeoChildEntitiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoChildEntities>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoChildEntitiesConverter.CreateOpenXmlElement<DXO16DCD.GeoChildEntities>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
