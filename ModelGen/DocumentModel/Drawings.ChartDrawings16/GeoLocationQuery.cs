namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoLocationQuery Class.
/// </summary>
public partial class GeoLocationQuery: ModelElement<DXO16DCD.GeoLocationQuery>
{
  public GeoLocationQuery(): base(){ }
  
  public GeoLocationQuery(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoLocationQuery(DXO16DCD.GeoLocationQuery openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? CountryRegion
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CountryRegion);
    }
    set
    {
      _ExistingElement.CountryRegion = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? AdminDistrict1
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AdminDistrict1);
    }
    set
    {
      _ExistingElement.AdminDistrict1 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? AdminDistrict2
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AdminDistrict2);
    }
    set
    {
      _ExistingElement.AdminDistrict2 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? PostalCode
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.PostalCode);
    }
    set
    {
      _ExistingElement.PostalCode = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
