using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Graphic Object Data.
/// </summary>
public static class GraphicDataConverter
{
  /// <summary>
  ///   Uniform Resource Identifier
  /// </summary>
  public static String? GetUri(GraphicData? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(GraphicData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static DocumentModel.Drawings.GraphicData? CreateModelElement(GraphicData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GraphicData();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.GraphicData? value)
    where OpenXmlElementType : GraphicData, new()
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