namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public static class ExternalDataConverter
{
  /// <summary>
  /// RelId of the relationship for the external data, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetId(DXO2016DrawChartDraw.ExternalData openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2016DrawChartDraw.ExternalData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// True if the external link should automatically update, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetAutoUpdate(DXO2016DrawChartDraw.ExternalData openXmlElement)
  {
    return openXmlElement?.AutoUpdate?.Value;
  }
  
  private static void SetAutoUpdate(DXO2016DrawChartDraw.ExternalData openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoUpdate = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AutoUpdate = null;
  }
  
  public static DMDrawsChartDraws.ExternalData? CreateModelElement(DXO2016DrawChartDraw.ExternalData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ExternalData();
      value.Id = GetId(openXmlElement);
      value.AutoUpdate = GetAutoUpdate(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ExternalData? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ExternalData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetAutoUpdate(openXmlElement, value?.AutoUpdate);
      return openXmlElement;
    }
    return default;
  }
}
