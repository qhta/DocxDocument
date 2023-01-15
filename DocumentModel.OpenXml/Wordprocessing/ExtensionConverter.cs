namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Extension Class.
/// </summary>
public static class ExtensionConverter
{
  /// <summary>
  ///   uri, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static DocumentModel.Wordprocessing.Extension? CreateModelElement(DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Extension();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Extension? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension, new()
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