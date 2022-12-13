namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Address Class.
/// </summary>
public class AddressImpl: ModelElementImpl, Address
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AddressImpl(): base() {}
  
  public AddressImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Address openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// address1, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Address1
  {
    get => (System.String?)OpenXmlElement?.Address1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Address1 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CountryRegion
  {
    get => (System.String?)OpenXmlElement?.CountryRegion?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CountryRegion = (System.String?)value;
    }
  }
  
  /// <summary>
  /// adminDistrict1, this property is only available in Office 2016 and later.
  /// </summary>
  public String? AdminDistrict1
  {
    get => (System.String?)OpenXmlElement?.AdminDistrict1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AdminDistrict1 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// adminDistrict2, this property is only available in Office 2016 and later.
  /// </summary>
  public String? AdminDistrict2
  {
    get => (System.String?)OpenXmlElement?.AdminDistrict2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AdminDistrict2 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// postalCode, this property is only available in Office 2016 and later.
  /// </summary>
  public String? PostalCode
  {
    get => (System.String?)OpenXmlElement?.PostalCode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PostalCode = (System.String?)value;
    }
  }
  
  /// <summary>
  /// locality, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Locality
  {
    get => (System.String?)OpenXmlElement?.Locality?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Locality = (System.String?)value;
    }
  }
  
  /// <summary>
  /// isoCountryCode, this property is only available in Office 2016 and later.
  /// </summary>
  public String? IsoCountryCode
  {
    get => (System.String?)OpenXmlElement?.IsoCountryCode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IsoCountryCode = (System.String?)value;
    }
  }
  
}
