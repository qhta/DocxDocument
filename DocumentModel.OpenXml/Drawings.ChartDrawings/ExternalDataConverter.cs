namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public static class ExternalDataConverter
{
  /// <summary>
  /// RelId of the relationship for the external data, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// True if the external link should automatically update, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetAutoUpdate(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAutoUpdate(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
