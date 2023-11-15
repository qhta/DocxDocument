namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Address Class.
/// </summary>
public partial class Address: ModelElement<DXO16DCD.Address>
{
  public Address(): base(){ }
  
  public Address(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Address(DXO16DCD.Address openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   address1, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Address1
  {
    get => _Element?.Address1;
    set => _ExistingElement.Address1 = value;
  }
  
  
  /// <summary>
  ///   countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? CountryRegion
  {
    get => _Element?.CountryRegion;
    set => _ExistingElement.CountryRegion = value;
  }
  
  
  /// <summary>
  ///   adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? AdminDistrict1
  {
    get => _Element?.AdminDistrict1;
    set => _ExistingElement.AdminDistrict1 = value;
  }
  
  
  /// <summary>
  ///   adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? AdminDistrict2
  {
    get => _Element?.AdminDistrict2;
    set => _ExistingElement.AdminDistrict2 = value;
  }
  
  
  /// <summary>
  ///   postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? PostalCode
  {
    get => _Element?.PostalCode;
    set => _ExistingElement.PostalCode = value;
  }
  
  
  /// <summary>
  ///   locality, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Locality
  {
    get => _Element?.Locality;
    set => _ExistingElement.Locality = value;
  }
  
  
  /// <summary>
  ///   isoCountryCode, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? IsoCountryCode
  {
    get => _Element?.IsoCountryCode;
    set => _ExistingElement.IsoCountryCode = value;
  }
  
}
