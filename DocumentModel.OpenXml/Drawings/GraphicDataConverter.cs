namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Graphic Object Data.
/// </summary>
public static class GraphicDataConverter
{
  /// <summary>
  /// Uniform Resource Identifier
  /// </summary>
  private static String? GetUri(DXDraw.GraphicData openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.GraphicData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  public static DMDraws.GraphicData? CreateModelElement(DXDraw.GraphicData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.GraphicData();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.GraphicData? value)
    where OpenXmlElementType: DXDraw.GraphicData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      return openXmlElement;
    }
    return default;
  }
}
