namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoDataEntityQueryResult Class.
/// </summary>
public partial class GeoDataEntityQueryResult: ModelElement<DXO16DCD.GeoDataEntityQueryResult>
{
  public GeoDataEntityQueryResult(): base(){ }
  
  public GeoDataEntityQueryResult(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoDataEntityQueryResult(DXO16DCD.GeoDataEntityQueryResult openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoDataEntityQuery.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataEntityQuery? GeoDataEntityQuery
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoDataEntityQuery>();
      if (element != null)
        return GeoDataEntityQueryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoDataEntityQuery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoDataEntityQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoDataEntityQuery>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GeoData.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoData? GeoData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoData>();
      if (element != null)
        return GeoDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoDataConverter.CreateOpenXmlElement<DXO16DCD.GeoData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
