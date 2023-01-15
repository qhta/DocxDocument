using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Custom XML Attribute.
/// </summary>
public static class CustomXmlAttributeConverter
{
  /// <summary>
  ///   uri
  /// </summary>
  public static String? GetUri(CustomXmlAttribute? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(CustomXmlAttribute? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  /// <summary>
  ///   name
  /// </summary>
  public static String? GetName(CustomXmlAttribute? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(CustomXmlAttribute? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   val
  /// </summary>
  public static String? GetVal(CustomXmlAttribute? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(CustomXmlAttribute? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static DocumentModel.Wordprocessing.CustomXmlAttribute? CreateModelElement(CustomXmlAttribute? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CustomXmlAttribute();
      value.Uri = GetUri(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CustomXmlAttribute? value)
    where OpenXmlElementType : CustomXmlAttribute, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetName(openXmlElement, value?.Name);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}