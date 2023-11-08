namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Clear Class.
/// </summary>
public partial class Clear: ModelElement<DXO16DCD.Clear>
{
  public Clear(): base(){ }
  
  public Clear(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Clear(DXO16DCD.Clear openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoLocationQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoLocationQueryResults? GeoLocationQueryResults
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoLocationQueryResults>();
      if (element != null)
        return GeoLocationQueryResultsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoLocationQueryResults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoLocationQueryResultsConverter.CreateOpenXmlElement<DXO16DCD.GeoLocationQueryResults>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GeoDataEntityQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataEntityQueryResults? GeoDataEntityQueryResults
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoDataEntityQueryResults>();
      if (element != null)
        return GeoDataEntityQueryResultsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoDataEntityQueryResults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoDataEntityQueryResultsConverter.CreateOpenXmlElement<DXO16DCD.GeoDataEntityQueryResults>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GeoDataPointToEntityQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoDataPointToEntityQueryResults? GeoDataPointToEntityQueryResults
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoDataPointToEntityQueryResults>();
      if (element != null)
        return GeoDataPointToEntityQueryResultsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoDataPointToEntityQueryResults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoDataPointToEntityQueryResultsConverter.CreateOpenXmlElement<DXO16DCD.GeoDataPointToEntityQueryResults>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GeoChildEntitiesQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildEntitiesQueryResults? GeoChildEntitiesQueryResults
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoChildEntitiesQueryResults>();
      if (element != null)
        return GeoChildEntitiesQueryResultsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoChildEntitiesQueryResults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoChildEntitiesQueryResultsConverter.CreateOpenXmlElement<DXO16DCD.GeoChildEntitiesQueryResults>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GeoParentEntitiesQueryResults.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoParentEntitiesQueryResults? GeoParentEntitiesQueryResults
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoParentEntitiesQueryResults>();
      if (element != null)
        return GeoParentEntitiesQueryResultsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoParentEntitiesQueryResults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoParentEntitiesQueryResultsConverter.CreateOpenXmlElement<DXO16DCD.GeoParentEntitiesQueryResults>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
