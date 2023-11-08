namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public partial class GeoDataPointToEntityQueryResult: ModelElement<DXO16DCD.GeoDataPointToEntityQueryResult>
{
  public GeoDataPointToEntityQueryResult(): base(){ }
  
  public GeoDataPointToEntityQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoDataPointToEntityQueryResult(DXO16DCD.GeoDataPointToEntityQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoDataPointQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataPointQuery? GeoDataPointQuery
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoDataPointQuery>();
      if (element != null)
        return GeoDataPointQueryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoDataPointQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoDataPointQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoDataPointQuery>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GeoDataPointToEntityQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataPointToEntityQuery? GeoDataPointToEntityQuery
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoDataPointToEntityQuery>();
      if (element != null)
        return GeoDataPointToEntityQueryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoDataPointToEntityQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoDataPointToEntityQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoDataPointToEntityQuery>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
