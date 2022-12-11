namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoLocationQuery Class.
/// </summary>
public class GeoLocationQueryImpl: ModelElementImpl, GeoLocationQuery
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoLocationQueryImpl(): base() {}
  
  public GeoLocationQueryImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocationQuery openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// countryRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CountryRegion
  {
    get => (String?)OpenXmlElement?.CountryRegion?.Value;
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
    get => (String?)OpenXmlElement?.AdminDistrict1?.Value;
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
    get => (String?)OpenXmlElement?.AdminDistrict2?.Value;
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
    get => (String?)OpenXmlElement?.PostalCode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PostalCode = (System.String?)value;
    }
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType
  {
    get => (EntityTypeEnum?)OpenXmlElement?.EntityType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EntityType = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum?)value;
    }
  }
  
}
