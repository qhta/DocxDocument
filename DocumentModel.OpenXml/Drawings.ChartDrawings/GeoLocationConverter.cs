namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocation Class.
/// </summary>
public static class GeoLocationConverter
{
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetLatitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLatitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetLongitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLongitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetEntityName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetEntityName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? GetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  public static void SetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation? openXmlElement, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(value);
  }
  
  /// <summary>
  /// Address.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.Address? GetAddress(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAddress(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation? openXmlElement, DocumentModel.Drawings.ChartDrawings.Address? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
