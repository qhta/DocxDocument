using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ExternalData Class.
/// </summary>
public static class ExternalDataConverter
{
  /// <summary>
  ///   RelId of the relationship for the external data, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetId(ExternalData? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(ExternalData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   True if the external link should automatically update, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetAutoUpdate(ExternalData? openXmlElement)
  {
    return openXmlElement?.AutoUpdate?.Value;
  }

  public static void SetAutoUpdate(ExternalData? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AutoUpdate = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.AutoUpdate = null;
  }

  public static DocumentModel.Drawings.ChartDrawings.ExternalData? CreateModelElement(ExternalData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ExternalData();
      value.Id = GetId(openXmlElement);
      value.AutoUpdate = GetAutoUpdate(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ExternalData? value)
    where OpenXmlElementType : ExternalData, new()
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