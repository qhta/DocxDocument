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
    get
    {
      return StringValueConverter.GetValue(_Element?.Address1);
    }
    set
    {
      _ExistingElement.Address1 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
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
  
  
  /// <summary>
  ///   locality, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Locality
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Locality);
    }
    set
    {
      _ExistingElement.Locality = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   isoCountryCode, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? IsoCountryCode
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.IsoCountryCode);
    }
    set
    {
      _ExistingElement.IsoCountryCode = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
