namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoChildEntitiesQuery Class.
/// </summary>
public partial class GeoChildEntitiesQuery: ModelElement<DXO16DCD.GeoChildEntitiesQuery>
{
  public GeoChildEntitiesQuery(): base(){ }
  
  public GeoChildEntitiesQuery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoChildEntitiesQuery(DXO16DCD.GeoChildEntitiesQuery openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? EntityId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.EntityId);
    }
    set
    {
      _ExistingElement.EntityId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   GeoChildTypes.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoChildTypes? GeoChildTypes
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoChildTypes>();
      if (element != null)
        return GeoChildTypesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoChildTypes>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoChildTypesConverter.CreateOpenXmlElement<DXO16DCD.GeoChildTypes>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
