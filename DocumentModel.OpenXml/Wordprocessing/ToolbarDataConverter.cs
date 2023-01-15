using DocumentFormat.OpenXml.Office.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the ToolbarData Class.
/// </summary>
public static class ToolbarDataConverter
{
  /// <summary>
  ///   id
  /// </summary>
  public static String? GetId(ToolbarData? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(ToolbarData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static DocumentModel.Wordprocessing.ToolbarData? CreateModelElement(ToolbarData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ToolbarData();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ToolbarData? value)
    where OpenXmlElementType : ToolbarData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}