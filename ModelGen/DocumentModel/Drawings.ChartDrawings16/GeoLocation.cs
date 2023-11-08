namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoLocation Class.
/// </summary>
public partial class GeoLocation: ModelElement<DXO16DCD.GeoLocation>
{
  public GeoLocation(): base(){ }
  
  public GeoLocation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoLocation(DXO16DCD.GeoLocation openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   latitude, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? Latitude
  {
    get
    {
      return _Element?.Latitude?.Value;
    }
    set
    {
      _ExistingElement.Latitude = value;
    }
  }
  
  
  /// <summary>
  ///   longitude, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? Longitude
  {
    get
    {
      return _Element?.Longitude?.Value;
    }
    set
    {
      _ExistingElement.Longitude = value;
    }
  }
  
  
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? EntityName
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.EntityName);
    }
    set
    {
      _ExistingElement.EntityName = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Address.
  /// </summary>
  [DataMember]
  public DMDCD16.Address? Address
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.Address>();
      if (element != null)
        return AddressConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Address>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AddressConverter.CreateOpenXmlElement<DXO16DCD.Address>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
