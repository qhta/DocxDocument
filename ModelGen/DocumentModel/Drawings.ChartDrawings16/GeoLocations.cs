namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoLocations Class.
/// </summary>
public partial class GeoLocations: ModelElement<DXO16DCD.GeoLocations>
{
  public GeoLocations(): base(){ }
  
  public GeoLocations(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoLocations(DXO16DCD.GeoLocations openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoLocation.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoLocation? GeoLocation
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoLocation>();
      if (element != null)
        return GeoLocationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoLocation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoLocationConverter.CreateOpenXmlElement<DXO16DCD.GeoLocation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
